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
    }
}
