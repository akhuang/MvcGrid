using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Zing.UI.Fluent;
using Zing.UI.Html;

namespace Zing.UI
{
    public class ViewComponentFactory
    {
        public ViewComponentFactory(HtmlHelper htmlHelper)
        {
            this.HtmlHelper = htmlHelper;
            this.Initializer = DependencyResolver.Current.GetService<IJavaScriptInitializer>();
        }

        public HtmlHelper HtmlHelper
        {
            get;
            set;
        }

        public IJavaScriptInitializer Initializer
        {
            get;
            private set;
        }

        public virtual GridBuilder<T> Grid<T>() where T : class
        {
            return GridBuilder<T>.Create(new Grid<T>(Initializer, DependencyResolver.Current.GetService<IGridHtmlBuilder>()));
        }
    }

    public class ViewComponentFactory<TModel> : ViewComponentFactory
    {
        public ViewComponentFactory(HtmlHelper<TModel> htmlHelper)
            : base(htmlHelper)
        {
            this.HtmlHelper = htmlHelper;
        }

        //why override HtmlHelper
        public new HtmlHelper<TModel> HtmlHelper
        {
            get;
            set;
        }
    }
}
