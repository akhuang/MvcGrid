using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI
{
    public interface IGridModel
    {
    }

    public class GridModel : IGridModel
    {
        public GridModel() { }
        public GridModel(IEnumerable data)
        {
            Data = data;
        }

        public IEnumerable Data
        {
            get;
            set;
        }
    }

    public class GridModel<T> : IGridModel
    {
        public GridModel()
        {
        }
        public GridModel(IEnumerable<T> data)
        {
            Data = data;
        }

        public IEnumerable<T> Data
        {
            get;
            set;
        }
    }
}
