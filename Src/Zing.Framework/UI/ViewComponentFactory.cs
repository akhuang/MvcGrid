using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Zing.UI
{
    public class ViewComponentFactory
    {
        public ViewComponentFactory(HtmlHelper htmlHelper)
        {
            this.HtmlHelper = htmlHelper;
        }

        public HtmlHelper HtmlHelper
        {
            get;
            set;
        }

        public 
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
