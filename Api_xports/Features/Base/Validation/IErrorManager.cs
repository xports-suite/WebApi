using Api_xports.Features.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.Validation
{
    ///
    public interface IErrorManager
    {
        ///
        CError AddError(string mensajeError, string origin, System.Exception exception,MethodBase methodBase, string jsonModel = null);
        ///
        CError AddError(string mensajeError, string origin, MethodBase methodBase, string jsonModel = null);
        ///
        CError AddError(string mensajeError, string origin, CError error, MethodBase methodBase, string jsonModel = null);
    }
}
