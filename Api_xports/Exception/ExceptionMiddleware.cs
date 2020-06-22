using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Api_xports.Features.Base;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Log;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Api_xports.Exception
{
    /// <summary>
    /// 
    /// </summary>
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILog _log;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="next"></param>
        /// <param name="log"></param>
        public ExceptionMiddleware(RequestDelegate next, ILog log)
        {
            _next = next;
            _log = log;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                var bodyStr = "";
                var req = httpContext.Request;
                req.EnableBuffering();
                using (StreamReader reader = new StreamReader(req.Body, Encoding.UTF8, true, 1024, true))
                {
                    bodyStr = await reader.ReadToEndAsync();
                    req.Body.Position = 0;
                }

                string _contenido = req.Path + " Cuerpo " + bodyStr;
                _log.Debug(_contenido);
                await _next(httpContext);
            }
            
            catch (System.Exception ex)
            {
                string msjError = "";
                var cerror = (CError)ex;
                foreach(var ierro in cerror.ErrorDetails)
                {
                    string message = ierro.InnerException == null ? "" : ierro.InnerException.Message;
                    msjError += message;
                }
                
                _log.Error($"ERROR 500 Internal Server Error: {msjError}");
                await HandleExceptionAsync(httpContext, ex);
            }
           

            if (!httpContext.Response.HasStarted)
            {
                httpContext.Response.ContentType = "application/json";

                var response = new ApiResponse(httpContext.Response.StatusCode);

                var json = JsonConvert.SerializeObject(response);

                await httpContext.Response.WriteAsync(json);
            }
        }



        private async Task HandleExceptionAsync(HttpContext context, System.Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var errorDetail = new ErrorDetails
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Errores = new List<ItemError>()
            };
            try
            {
                if(exception.GetType() == typeof(CError))
                {
                    var errors = (CError)exception;
                    foreach (var ierr in errors.ErrorDetails)
                    {
                        errorDetail.Errores.Add(new ItemError { Codigo = ierr.Origen, Message = ierr.Error });
                    }
                }
                else
                {
                    errorDetail.Errores.Add(new ItemError { Codigo = "error interno", Message = exception.Message });
                }
               
            }
            catch (System.Exception) { }

            context.Response.ContentType = "application/json";
            string jsonString = JsonConvert.SerializeObject(errorDetail);
            await context.Response.WriteAsync(jsonString, System.Text.Encoding.UTF8);
        }
    }
}
