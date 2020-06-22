using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Cuenta.DTO
{
    ///
    public class TokenResponse_Dto
    {
        ///
        public string token { get; set; }
        ///
        public string refresh_token { get; set; }
        ///
        public string invalid_request { get; set; }
        ///
        public string ValidateToken { get; set; }
        
    }
}
