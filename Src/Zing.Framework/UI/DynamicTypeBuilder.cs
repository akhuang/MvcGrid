using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace Zing.UI
{
    static class DynamicTypeBuilder
    {
        private const string Prefix = "Zing.Web.Mvc.{Dynamic}";

        private static readonly ModuleBuilder dynamicModule = CreateDynamicModule();

        private static ModuleBuilder CreateDynamicModule()
        {
            return AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName(Prefix), AssemblyBuilderAccess.Run)
                .DefineDynamicModule(Prefix + ".dll");
        }

    }
}
