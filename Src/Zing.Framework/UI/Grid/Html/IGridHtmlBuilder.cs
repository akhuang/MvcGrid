using System.Collections.Generic;
using Zing.UI.Html;

namespace Zing.UI.Html
{
    public interface IGridHtmlBuilder
    {
        IHtmlNode CreateGrid(IDictionary<string, object> htmlAttributes, GridRenderingData body);
    }
}
