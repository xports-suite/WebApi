using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///Clase para representar una retorno de error de una api
    public class ApiBadRequestResponse : ApiResponse
    {
        /// Metodo donde guardamos los errores
        public IEnumerable<string> Errors { get; }

        /// Construtor de clase
        public ApiBadRequestResponse(ModelStateDictionary modelState)
            : base(400)
        {
            if (modelState.IsValid)
            {
                throw new ArgumentException("ModelState must be invalid", nameof(modelState));
            }

            Errors = modelState.SelectMany(x => x.Value.Errors)
                .Select(x => x.ErrorMessage).ToArray();
        }
    }
}
