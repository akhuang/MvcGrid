using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Zing.UI
{
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class GridActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                return;
            }
            var viewResult = filterContext.Result as ViewResultBase;
            var dataSource = viewResult.ViewData.Model;

            var result = new Dictionary<string, object>();
            result["data"] = dataSource;

            filterContext.Result = new JsonResult() { Data = result };
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
        }
    }
}
