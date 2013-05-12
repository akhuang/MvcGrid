using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;

namespace Zing.Extensions
{
    public static class ExpressionExtensions
    {
        public static string MemberWithoutInstance(this LambdaExpression expression)
        {
            return ExpressionHelper.GetExpressionText(expression);
        }
    }
}
