using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;

namespace Zing.UI
{
    public abstract class ComponentBuilderBase<TComponent, TBuilder>
        where TBuilder : class
        where TComponent : class
    {
        private static readonly Func<TComponent, TBuilder> creator = GetCreator();

        public static TBuilder Create(TComponent component)
        {
            return creator(component);
        }

        private static Func<TComponent, TBuilder> GetCreator()
        {
            var builderType = typeof(TBuilder);
            var componentType = typeof(TComponent);
            var htmlStringType = typeof(HttpContext).Assembly.GetType("System.Web.IHtmlString");
            var targetType = typeof(TBuilder);

            if (htmlStringType != null)
            {
                targetType = DynamicTypeBuilder.GenerateType(builderType, new[] { htmlStringType });
            }

            var argumentExpressoion = Expression.Parameter(componentType, "component");
            //componentType为指定的参数
            var constructor = targetType.GetConstructor(new Type[] { componentType });

            var newExpression = Expression.New(constructor, argumentExpressoion);

            return Expression.Lambda<Func<TComponent, TBuilder>>(newExpression, argumentExpressoion).Compile();
        }
    }
}
