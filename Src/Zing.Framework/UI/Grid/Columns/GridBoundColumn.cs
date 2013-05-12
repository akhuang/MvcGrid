using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Zing.UI
{
    public class GridBoundColumn<TModel, TValue> : IGridBoundColumn where TModel : class
    {
        public GridBoundColumn(Grid<TModel> grid, Expression<Func<TModel, TValue>> expression)
        {
            this.Grid = grid;
        }

        public Grid<TModel> Grid
        {
            get;
            set;
        }

        public string Member
        {
            get;
            set;
        }

        public Type MemberType
        {
            get;
            set;
        }
    }
}
