using Api_xports.Features.Base.Validation;
using Api_xports.Features.Cuenta.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Cuenta.services
{
    ///
    public interface ICuentaService
    {
        ///
        Task<ValidationModel> Login(UserLogin_Dto request);
    }
}
