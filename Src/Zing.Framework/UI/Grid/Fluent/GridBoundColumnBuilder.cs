using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI.Fluent
{
    public class GridBoundColumnBuilder<T> where T : class
    {
        //private IGridBoundColumn _column;
        public GridBoundColumnBuilder(IGridBoundColumn column)
        {
            Column = column;
        }

        public IGridBoundColumn Column
        {
            get;
            set;
        }
    }
}
