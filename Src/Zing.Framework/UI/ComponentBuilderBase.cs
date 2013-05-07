using System;
using System.Collections.Generic;
using System.Linq;
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
            var componentBase = typeof(TComponent);
            var htmlStringType = typeof(HttpContext).Assembly.GetType("System.Web.IHtmlString");
            var targetType = typeof(TBuilder);

            if (htmlStringType != null)
            {
                targetType=
            }
        }
    }
}
