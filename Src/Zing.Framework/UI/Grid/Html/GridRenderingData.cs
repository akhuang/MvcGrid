using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI.Html
{
    public class GridRenderingData
    {
        public IEnumerable DataSource
        {
            get;
            set;
        }

        public IEnumerable<IGridBoundColumn> Columns
        {
            get;
            set;
        }
    }
}
