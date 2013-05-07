using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Zing.UI
{
    public class HtmlHelperExtension
    {
        public static ViewComponentFactory<TModel> CRM<TModel>(this HtmlHelper<TModel> htmlHelper)
        {
            return new ViewComponentFactory<TModel>(htmlHelper);
        }
    }
}
