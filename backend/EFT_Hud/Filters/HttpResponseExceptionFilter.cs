using System;
using System.Net;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace EFT_Hud.Filters
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; set; }

        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is Exception exception)
            {
                context.Result = new ObjectResult(exception.ToString())
                {
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    ContentTypes = new MediaTypeCollection()
                    {
                        MediaTypeNames.Application.Json
                    }
                };
                context.ExceptionHandled = true;
            }

            //TODO: Error handling
        }
    }
}
