using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI
{
    public interface IJavaScriptInitializer
    {
        IJavaScriptSerializer CreateSerializer();

        string Initialize(string id, string name, IDictionary<string, object> options);

        string InitializeFor(string selector, string name, IDictionary<string, object> options);

        string Serialize(IDictionary<string, object> value);
    }
}
