using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Zing.UI.Fluent
{
    public class GridColumnFactory<TModel> where TModel : class
    {
        public GridColumnFactory(Grid<TModel> container)
        {
            Container = container;
        }

        public Grid<TModel> Container
        {
            get;
            private set;
        }

        public virtual GridBoundColumnBuilder<TModel> Bound<TValue>(Expression<Func<TModel, TValue>> expression)
        {
            GridBoundColumn<TModel, TValue> column = new GridBoundColumn<TModel, TValue>(Container, expression);

            Container.Columns.Add(column);

            return new GridBoundColumnBuilder<TModel>(column);
        }
    }
}
