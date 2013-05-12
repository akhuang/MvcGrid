using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using Zing.UI.Html;

namespace Zing.UI
{
    public class Grid<T> : ViewComponentBase where T : class
    {
        public Grid(IGridHtmlBuilder gridHtmlBuilder)
            : base()
        {
            this.GridHtmlBuilder = gridHtmlBuilder;
            this.Columns = new List<IGridBoundColumn>();
        }

        public IGridHtmlBuilder GridHtmlBuilder
        {
            get;
            set;
        }

        public IList<IGridBoundColumn> Columns
        {
            get;
            private set;
        }

        public IList<IGridBoundColumn> VisibleColumns
        {
            get
            {
                return Columns;
            }

        }

        protected override void WriteHtml(HtmlTextWriter writer)
        {
            var renderingData = CreateRenderingData();

            var container = GridHtmlBuilder.CreateGrid(HtmlAttributes, renderingData);

            container.WriteTo(writer);

            base.WriteHtml(writer);
        }

        private GridRenderingData CreateRenderingData()
        {
            var renderingData = new GridRenderingData()
            {
                Columns = VisibleColumns
            };

            return renderingData;
        }
    }
}
