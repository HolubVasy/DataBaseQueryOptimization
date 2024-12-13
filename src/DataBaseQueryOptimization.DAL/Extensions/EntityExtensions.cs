using System.Linq.Expressions;
using DataBaseQueryOptimization.DAL.Common.Models.Entities;

namespace DataBaseQueryOptimization.DAL.Extensions
{
    public static class EntityExtensions
    {
        /// <summary>
        /// This generic method is responsible for populating the navigation collection data
        /// in EmployeeDto objects.
        /// It takes a collection of EmployeeDto objects and populates their navigation
        /// collection property using the provided projection function,
        /// ID selector, and navigation
        /// collection selector.
        /// </summary>
        /// <typeparam name="TEntity">Entity type.</typeparam>
        /// <typeparam name="TAttribute">The type of the navigation collection's elements.
        /// </typeparam>
        /// <param name="entityDictionary">Entity collection dictionary.</param>
        /// <param name="attributeCollection">Instance collection of related collection attribute.
        /// </param>
        /// <param name="getEntityIdentifier">A function to retrieve the entity identifier value
        /// from a navigation collection element.</param>
        /// <param name="navigationCollectionProperty">An expression, which allows retrieving
        /// the navigation collection property name from an <see cref="Employee"/> object.
        /// </param>
        /// <returns>An IEnumerable of EmployeeDto objects with the navigation collection data
        /// populated.</returns>
        public static IDictionary<Guid, TEntity> FillWithDependency<TEntity, TAttribute>(
            this IDictionary<Guid, TEntity> entityDictionary,
            IEnumerable<TAttribute> attributeCollection,
            Func<TAttribute, Guid> getEntityIdentifier,
            Expression<Func<TEntity, object>> navigationCollectionProperty) where TAttribute : 
        class
        {
            var navigationCollectionPropertyInfo =
                typeof(TEntity).GetProperty(navigationCollectionProperty.GetPropertyInfo().Name);

            // Iterate through the collection attribute, and for each attribute, find the
            // corresponding entity element from the dictionary.
            // If found, add the attribute collection element to the navigation collection
            // of the entity.
            // This is made for improving performance of retrieving related collection entities,
            // as retrieving collection navigation properties within one request with
            // the main request is not time efficient.
            foreach (var element in attributeCollection)
            {
                if (!entityDictionary.TryGetValue(getEntityIdentifier(element), 
                    out TEntity entity))
                {
                    continue;
                }

                var navigationCollectionValue = navigationCollectionPropertyInfo
                    .GetValue(entity) as List<TAttribute> ?? new List<TAttribute>();

                navigationCollectionPropertyInfo.SetValue(entity, navigationCollectionValue);
                navigationCollectionValue.Add(element);
            }

            // Returning dictionary allows us to add a couple of navigation collection properties
            // one after one,
            // using fluent API notation.
            return entityDictionary;
        }
    }
}
