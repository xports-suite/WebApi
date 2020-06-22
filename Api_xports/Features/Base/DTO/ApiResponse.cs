using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///Clase Base para devolver las respuestas.
    public class ApiResponse
    {
        /// Propiedad que guarda el Statu
        public int StatusCode { get; }

        /// Message a devolver
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; }
        ///Construtor de clase
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }
        // Metodo que devuelve mensaje en funcion del estado de error
        private static string GetDefaultMessageForStatusCode(int statusCode)
        {
            switch (statusCode)
            {

                case 404:
                    return "Resource not found";
                case 500:
                    return "An unhandled error occurred";
                default:
                    return null;
            }
        }
    }
}
