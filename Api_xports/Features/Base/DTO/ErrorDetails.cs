using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///
    public class ErrorDetails
    {
        ///
        public ErrorDetails()
        {

        }
        ///
        public ErrorDetails(IEnumerable<ValidationResult> validationResults)
        {
            StatusCode = (int)HttpStatusCode.BadRequest;
            Errores = new List<ItemError>();
            foreach (var validationResult in validationResults)
            {
                Errores.Add(new ItemError { Codigo = validationResult.ErrorMessage, Message = validationResult.MemberNames.Single() });
            }
        }
        ///
        public ErrorDetails(int statusCode, string message)
        {
            this.StatusCode = statusCode;
            this.Message = message;
        }
        ///
        public int StatusCode { get; set; }
        ///
        public List<ItemError> Errores { get; set; }
        ///
        public string Message { get; set; }

   
    }
    ///
    public class ItemError
    {
        ///
        public string Codigo { get; set; }
        ///
        public string Message { get; set; }
    }
}
