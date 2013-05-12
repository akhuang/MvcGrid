using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI.Fluent
{
    public class GridBuilder<T> : ViewComponentBuilderBase<Grid<T>, GridBuilder<T>> where T : class
    {
        public GridBuilder(Grid<T> component)
            : base(component)
        {

        }

        public GridBuilder<T> Columns(Action<GridColumnFactory<T>> configurator)
        {
            GridColumnFactory<T> factory = new GridColumnFactory<T>(Component);
            configurator(factory);
            return this;
        }
    }
}
