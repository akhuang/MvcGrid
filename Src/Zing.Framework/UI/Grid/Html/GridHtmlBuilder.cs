using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zing.UI.Html;

namespace Zing.UI.Html
{
    public class GridHtmlBuilder : IGridHtmlBuilder
    {
        public IHtmlNode CreateGrid(IDictionary<string, object> htmlAttributes, GridRenderingData renderingData)
        {
            var div = new HtmlElement("div").Attributes(htmlAttributes)
                                       .PrependClass(UIPrimitives.Widget, "t-grid");

            AppendData(div, renderingData);

            return div;
        }

        protected virtual void AppendData(IHtmlNode div, GridRenderingData renderingData)
        {
            //var table = CreateTable(renderingData);

            var table = new HtmlElement("table")
                         .Attribute("cellspacing", "0");

            //var colgroup = new HtmlElement("colgroup");
            //colgroup.AppendTo(table);

            //foreach (var colData in colsData)
            //{
            //    AppendCol(colgroup, colData.Width, colData.Hidden);
            //}

            //ApplyDecorators(table);

            table.AppendTo(div);

            AppendHeader(table, renderingData);

            //AppendFooter(table, renderingData);

            //var tbody = CreateBody(renderingData);
            //tbody.AppendTo(table);
        }

        protected void AppendHeader(IHtmlNode container, GridRenderingData renderingData)
        {
            var thead = new HtmlElement("thead").AddClass("t-grid-header");

            var tr = new HtmlElement("tr");

            foreach (var col in renderingData.Columns)
            {
                var th = new HtmlElement("th")
                   .Attribute("scope", "col")
                    //.Attributes(htmlAttributes)
                   .PrependClass(UIPrimitives.Header);
                th.Html(col.Title);
                th.AppendTo(tr);
            }

            tr.AppendTo(thead);

            thead.AppendTo(container);
        }


    }
}
