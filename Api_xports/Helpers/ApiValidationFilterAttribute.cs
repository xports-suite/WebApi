using Api_xports.Features.Base;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Log;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api_xports.Helpers
{
    ///
    public class ApiValidationFilterAttribute : IActionFilter
    {
        ///
        private readonly ILog _looger;
        ///
        public ApiValidationFilterAttribute(ILog looger)
        {
            _looger = looger;
        }
        ///
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //_looger.Error("OnActionExecuted");
            if (context.Result != null && context.Result.GetType() == typeof(BadRequestObjectResult))
            {
                var badRequestObjectResult = (BadRequestObjectResult)context.Result;

                try
                {
                    var validationModel = (ValidationModel)badRequestObjectResult.Value;
                    var validationResults = validationModel.GetValidationsErrors();
                    var errorDetails = new ErrorDetails(validationResults);
                    ErrorResposen _response = new ErrorResposen();
                    _response.message = errorDetails.Errores[0].Message;
                    _response.statusCode = "404";
                    badRequestObjectResult.Value = _response;
                }
                catch { }

                _looger.Error("BadRequestObjectResult");
            }
            if (context.Result != null && context.Result.GetType() == typeof(ApiResponseNoOk))
            {
                _looger.Error("ApiResponseNoOk");
            }
            if (context.Result != null && context.Result.GetType() == typeof(NotFoundObjectResult))
            {
                _looger.Error("NotFoundObjectResult");
            }
            
        }
        ///
        public void OnActionExecuting(ActionExecutingContext context)
        {
            //_looger.Error("OnActionExecuting");
        }
    }
}
