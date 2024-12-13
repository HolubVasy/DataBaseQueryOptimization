using System.Linq.Expressions;
using System.Reflection;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;

namespace DataBaseQueryOptimization.DAL.Builders
{
/// <summary>
/// Greats projection for the Select() extension method in the <see>
///     <cref>DbSet{TEntity}</cref>
/// </see>
/// derived classes.
/// This is a haw I have found out the
/// <see href="https://learn.microsoft.com/en-us/ef/core/performance/efficient-querying#project-only-properties-you-need">HERE</see>
/// </summary>
/// <remarks>Created for improving performance of a creation
/// query using EF database context, using
/// projection.</remarks>
/// <typeparam name="TSource">Entity type of the <see>
///         <cref>DbSet{TEntity}</cref>
///     </see>
///     instance.</typeparam>
/* This builder allows to such things

    var employees = _context
        .Employees
        .Select( cws =>
            new Employees{
                Id = cws.EmployeeId,
                EmailCorp = cws.EmailCorp,
                Location = new C1Location
                {
                    Location = cws.Location.Location
                },
                Department = new C1DepartmentType
                {
                    Location = cws.Department.DepartmentType
                },
                Position = new C1WorkingStaffPosition
                {
                    Location = cws.Position.Position
                }
            });


    Rewrites in the following way, where under hood it is used projection,
    which allows take only fields that are required, that optimizes
    performance. This way also allows avoiding errors, related to
    indicating nested properties, like 'cws.Position.Positions'. If at the two levels,
    presented same properties name, it is easy to commit an error. So such a solution is
    less error-prone.

    var employeeProjections = new ProjectionBuilder<Employees>()
        .Take(x => x.EmployeeId)
        .Take(x => x.EmailCorp)
        .Take(x => x.Location)    				// Nested property is not showed fully, only indicated property
                                                // inside With() method are used in the query.
        .With<C1Location>(x => x.Location)      // For the nested properties important indicate type, in our case
                                                // this is a generic type C1Location.
        .Take(x => x.Department)  				// Nested property is not showed fully, only indicated property
                                                // inside With() method are used in the query.
        .With<C1DepartmentType>(x => x.DepartmentType)
        .Take(x => x.Position)    				// Nested property is not showed fully, only indicated property
                                                // inside With() method are used in the query.
        .With<C1WorkingStaffPosition>(x => x.Position)
        .Build();

    var employees = _context
        .Employees
        .Select(employeeProjections);

    */
    public class ProjectionBuilder<TSource>
    {
        /// <summary>
        /// Contains information about nested properties.
        /// </summary>
        /// <example>For example, for a <see cref="Project"/> instance it can be
        /// DeliveryManager, which have any properties as for usual employees. To contain
        /// information about such nested property and his own properties, we use a record in a
        /// dictionary, where key this is a <see cref="Employee"/> instance, and as a value
        /// this is list of <see cref="PropertyInfo"/>, which are indicated via dictionary as
        /// properties, what should be included in the SQL request to the database.</example>
        private readonly Dictionary<PropertyInfo, List<PropertyInfo>> _relatedProperties;

        /// <summary>
        /// Container for not nested properties, which are indicated via builder notation.
        /// </summary>
        private List<PropertyInfo> _propertyInfos;

        public ProjectionBuilder()
        {
            _propertyInfos = new List<PropertyInfo>();
            _relatedProperties = new Dictionary<PropertyInfo, List<PropertyInfo>>();
        }

        /// <summary>
        /// Puts indicated in the argument field into actual SQL request.
        /// </summary>
        /// <param name="selector">Contains a field in a view of expression tree,
        /// to avoid errors in the properties' names.</param>
        /// <returns>Builder instance.</returns>
        public ProjectionBuilder<TSource> Take(Expression<Func<TSource, object>> selector)
        {
            var propertyInfo = GetPropertyInfo(selector);
            _propertyInfos.Add(propertyInfo);
            return this;
        }

        /// <summary>
        /// Puts nested properties into SQL request.
        /// </summary>
        /// <param name="selector">Contains a field in a view of expression tree,
        /// to avoid errors in the properties' names.</param>
        /// <typeparam name="TProperty">Type of nested property. It is important to indicate it.
        /// </typeparam>
        /// <example>If we have employee instance, so for it Location property would be
        /// nested, and within this method we indicate one of the Location type properties,
        /// for example, Location property as string.</example>
        /// <returns>Builder instance.</returns>
        public ProjectionBuilder<TSource> With<TProperty>(
            Expression<Func<TProperty,object>> selector)
        {
            var propertyInfo = GetPropertyInfo(selector);
            var lastPropertyInfo = _propertyInfos[^1];

            if (!_relatedProperties.ContainsKey(lastPropertyInfo))
            {
                _relatedProperties[lastPropertyInfo] = new List<PropertyInfo>();
            }

            _relatedProperties[lastPropertyInfo].Add(propertyInfo);

            return this;
        }

        /// <summary>
        /// Builds expression tree, containing projection for a Select method.
        /// </summary>
        /// <returns>Expression tree, containing query details (field
        /// list and their dependencies).
        /// </returns>
        public Expression<Func<TSource, TSource>> Build()
        {
            _propertyInfos = RemoveNestedPropertyInfos(_propertyInfos, _relatedProperties);

            var sourceType = typeof(TSource);
            var source = Expression.Parameter(sourceType, "source");

            var memberBindings=(from property in _propertyInfos
                    let sourceProperty=Expression.Property(source,
                        property)
                    select Expression.Bind(sourceType.GetProperty(property.Name),
                        sourceProperty)).Cast<MemberBinding>()
                .ToList();

            // Non-nested properties
            
            // Nested properties
            foreach (var entry in _relatedProperties)
            {
                var parentProperty = entry.Key;
                var childProperties = entry.Value.ToArray();

                var nestedSourceProperty = Expression.Property(source,
                    parentProperty);
                var nestedBindings=(from nestedProperty in childProperties
                        let nestedSourceChildProperty=Expression
                            .Property(nestedSourceProperty,
                            nestedProperty)
                        select Expression.Bind(
                            nestedProperty.DeclaringType.GetProperty(nestedProperty.Name),
                            nestedSourceChildProperty)).Cast<MemberBinding>()
                    .ToList();
                
                var newNestedObject =
                    Expression.MemberInit(Expression.New(parentProperty.PropertyType), 
                        nestedBindings);

                // Null check for the nested property
                var nullCheck = Expression.NotEqual(nestedSourceProperty,
                    Expression.Constant(null, parentProperty.PropertyType));
                var nullConditionalExpression = Expression.Condition(nullCheck, newNestedObject,
                    Expression.Constant(null, parentProperty.PropertyType));

                MemberBinding nestedMemberBinding=Expression.Bind(
                    sourceType.GetProperty(parentProperty.Name),
                    nullConditionalExpression);
                memberBindings.Add(nestedMemberBinding);
            }

            var newTargetObject = Expression.MemberInit(Expression.New(sourceType), memberBindings);
            var lambda = Expression.Lambda<Func<TSource, TSource>>(newTargetObject, source);

            return lambda;
        }

        private List<PropertyInfo> RemoveNestedPropertyInfos(List<PropertyInfo> propertyInfos,
            Dictionary<PropertyInfo, List<PropertyInfo>> relatedProperties)
        {
            return propertyInfos
                .Where(pi => !relatedProperties.Keys.Select(k => k.Name).Contains(pi.Name))
                .ToList();
        }

        /// <summary>
        /// Retrieves <see cref="PropertyInfo"/> instance based on expression tree content.
        /// </summary>
        /// <param name="property">Property information in a shape of a expression tree.</param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="PropertyInfo"/> instance, related with property, indicated
        /// as an argument in a shape of expression tree.</returns>
        private static PropertyInfo GetPropertyInfo<T>(
            Expression<Func<T, object>> property)
        {
            LambdaExpression lambda = property;
            MemberExpression memberExpression;

            if (lambda.Body is UnaryExpression expression)
            {
                memberExpression = (MemberExpression)expression.Operand;
            }
            else
            {
                memberExpression = (MemberExpression)lambda.Body;
            }

            return (PropertyInfo)memberExpression.Member;
        }
    }
}
