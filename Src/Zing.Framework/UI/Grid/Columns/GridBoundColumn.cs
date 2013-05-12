using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using Zing.Extensions;

namespace Zing.UI
{
    public class GridBoundColumn<TModel, TValue> : IGridBoundColumn where TModel : class
    {
        public GridBoundColumn(Grid<TModel> grid, Expression<Func<TModel, TValue>> expression)
        {
            this.Grid = grid;

            Metadata = ModelMetadata.FromLambdaExpression(expression, new ViewDataDictionary<TModel>());
            Member = ExpressionHelper.GetExpressionText(expression);
            MemberType = Metadata.ModelType;
            Title = Metadata.DisplayName;

            if (string.IsNullOrEmpty(Title))
            {
                Title = Member.AsTitle();
            }
        }

        public Grid<TModel> Grid
        {
            get;
            set;
        }

        public ModelMetadata Metadata
        {
            get;
            private set;
        }

        public string Title { get; set; }

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
