using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zing.UI.Html;

namespace Zing.UI
{
    public class UIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GridHtmlBuilder>().As<IGridHtmlBuilder>();
            base.Load(builder);
        }
    }
}
