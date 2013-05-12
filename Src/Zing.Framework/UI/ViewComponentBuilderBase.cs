using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zing.UI
{
    public class ViewComponentBuilderBase<TViewComponent, TBuilder> : ComponentBuilderBase<TViewComponent, TBuilder>
        where TViewComponent : ViewComponentBase
        where TBuilder : ViewComponentBuilderBase<TViewComponent, TBuilder>
    {

        private TViewComponent _component;
        public ViewComponentBuilderBase(TViewComponent component)
        {
            this._component = component;
        }

        public TViewComponent Component
        {
            get { return _component; }
            set { _component = value; }
        }

        /// <summary>
        /// Returns the internal view component.
        /// </summary>
        /// <returns></returns>
        public TViewComponent ToComponent()
        {
            return Component;
        }

        public virtual TBuilder Name(string componentName)
        {
            Component.Name = componentName;
            return this as TBuilder;
        }

        public string ToHtmlString()
        {
            return ToComponent().ToHtmlString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
