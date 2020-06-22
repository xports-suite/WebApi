using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.DTO
{
    ///Clase que devuelve una respuesta OK
    public class ApiOkResponse : ApiResponse
    {
        ///Propiedad Result
        public object Result { get; }
        ///Contructor de clase
        public ApiOkResponse(object result)
            : base(200)
        {
            Result = result;
        }
    }
}
