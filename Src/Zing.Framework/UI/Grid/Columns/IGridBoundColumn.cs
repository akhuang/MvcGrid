using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI
{
    public interface IGridBoundColumn
    {
        string Member { get; set; }
        Type MemberType { get; set; }
    }
}
