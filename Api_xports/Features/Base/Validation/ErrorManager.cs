using Api_xports.Features.Base.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api_xports.Features.Base.Validation
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorManager : IErrorManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensajeError"></param>
        /// <param name="origin"></param>
        /// <param name="exception"></param>
        /// <param name="methodBase"></param>
        /// <param name="jsonModel"></param>
        /// <returns></returns>
        public CError AddError(string mensajeError, string origin, System.Exception exception, MethodBase methodBase, string jsonModel = null)
        {
            var errorDet = new CErrorDet(exception)
            {
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name + " - " + exception.Message + " - " + exception.StackTrace,
                Origen = origin,
                ModelInformation = jsonModel
            };
            var ce = new CError();
            ce.ErrorDetails.Add(errorDet);
            return ce;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensajeError"></param>
        /// <param name="origin"></param>
        /// <param name="methodBase"></param>
        /// <param name="jsonModel"></param>
        /// <returns></returns>
        public CError AddError(string mensajeError, string origin, MethodBase methodBase, string jsonModel = null)
        {
            var error = new CErrorDet
            {
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name,
                Origen = origin,
                ModelInformation = jsonModel
            };

            var ce = new CError();
            ce.ErrorDetails.Add(error);
            return ce;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mensajeError"></param>
        /// <param name="origin"></param>
        /// <param name="error"></param>
        /// <param name="methodBase"></param>
        /// <param name="jsonModel"></param>
        /// <returns></returns>
        public CError AddError(string mensajeError, string origin, CError error, MethodBase methodBase, string jsonModel = null)
        {
            var errorDet = new CErrorDet(error)
            {
                Error = mensajeError + " - En la clase: " + methodBase.ReflectedType.Name + " - En el método: " + methodBase.Name,
                Origen = origin,
                ModelInformation = jsonModel
            };
            error.ErrorDetails.Add(errorDet);
            return error;
        }
    }
}
