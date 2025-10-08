using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Academia.WebApi.Filters;

public class ExceptionManager : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        ObjectResult result;

        if (exception is ArgumentException)
        {
            result = new BadRequestObjectResult(new
            {
                error = exception.Message
            });
        }
        else
        {
            result = new ObjectResult(new
            {
                error = "Ocurrió un error inesperado. Intente nuevamente.",
                mensaje = exception.Message
            })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }

        context.Result = result;
        context.ExceptionHandled = true;
    } 
}
