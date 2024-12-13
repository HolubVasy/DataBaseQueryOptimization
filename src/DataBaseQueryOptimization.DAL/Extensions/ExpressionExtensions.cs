using System.Linq.Expressions;
using System.Reflection;

namespace DataBaseQueryOptimization.DAL.Extensions
{
    public static class ExpressionExtensions
    {
        /// <summary>
        /// Возвращает коллекцию <see cref="PropertyInfo"/> элементов на основании деревева
        /// выражения, переданного в качестве аргумента,
        /// для того, чтобы для маппинга переченя свойств определенного
        /// типа, использовать строго типизированные выражения, а не строки, чтобы не допускать
        /// ошибки в написании наименований свойств.
        /// </summary>
        /// <typeparam name="T">Тип данных, свойства которого анализируются.</typeparam>
        /// <param name="properties">Дерево выражения, представляющее собой данные о
        /// коллекции определенных свойств.
        /// Семантическое соответствие.</param>
        /// <returns>Перечень <see cref="PropertyInfo"/> элементов, которые соответствуют
        /// коллекции
        /// свойств типа <see cref="T"/>, выраженных
        /// в виде дерева варажений.</returns>
        public static IEnumerable<PropertyInfo> GetPropertyInfos<T>(
            this IEnumerable<Expression<Func<T, object>>> properties)
        {
            return properties
                .Select(GetPropertyInfo)
                .OrderBy(property => property.Name);
        }

        /// <summary>
        /// Возвращает <see cref="PropertyInfo"/> экземпляр на основании деревева выражения,
        /// переданного в качестве аргумента,
        /// или других местах кода, для того, чтобы для маппинга переченя свойств определенного
        /// типа, использовать строго типизированные выражения, а не строки, чтобы не допускать
        /// ошибки в написании наименований свойств.
        /// </summary>
        /// <typeparam name="T">Тип данных, свойства которого анализируются.</typeparam>
        /// <param name="property">Дерево выражения, представляющее собой данные о коллекции
        /// определенных свойств.
        /// Семантическое соответствие.</param>
        /// <returns><see cref="PropertyInfo"/> экземпляр, который соответствуeт экземпляру
        /// свойства типа <see cref="T"/>, выраженных
        /// в виде дерева варажений.</returns>
        public static PropertyInfo GetPropertyInfo<T>(
            this Expression<Func<T, object>> property)
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
