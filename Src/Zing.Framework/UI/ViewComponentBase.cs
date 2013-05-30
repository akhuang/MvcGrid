using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Routing;
using System.Web.UI;

namespace Zing.UI
{
    public abstract class ViewComponentBase
    {
        public ViewComponentBase(IJavaScriptInitializer initializer)
        {
            HtmlAttributes = new RouteValueDictionary();
            this.Initializer = initializer;
        }

        public IJavaScriptInitializer Initializer
        {
            get;
            private set;
        }

        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Gets the HTML attributes.
        /// </summary>
        /// <value>The HTML attributes.</value>
        public IDictionary<string, object> HtmlAttributes
        {
            get;
            private set;
        }


        public string ToHtmlString()
        {
            using (var output = new StringWriter())
            {
                WriteHtml(new HtmlTextWriter(output));
                return output.ToString();
            }
        }

        protected virtual void WriteHtml(HtmlTextWriter writer)
        {

        }
    }
}
