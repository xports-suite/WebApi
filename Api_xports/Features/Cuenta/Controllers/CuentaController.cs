using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_xports.Features.Base;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Cuenta.DTO;
using Api_xports.Features.Cuenta.services;
using Api_xports.Features.User.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api_xports.Features.Cuenta.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/oAuth")]
    [ApiController]
    
    public class CuentaController : ControllerBase
    {
        private readonly ICuentaService _cuentaSrv;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cuentaSrv"></param>
        /// <param name="userSrv"></param>
        public CuentaController(ICuentaService cuentaSrv ,
            IUserServices userSrv)
        {
            _cuentaSrv = cuentaSrv;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost("SignIn")]
        [SwaggerOperation(Summary = "Login de usuario",
          Description = "Login de usuario",
          OperationId = "SignIn")]
        public async Task<IActionResult> Login([FromBody] UserLogin_Dto userInfo)
        {
            try
            {
                var result = await _cuentaSrv.Login(userInfo);
                if (result.HasValidationErrors())
                {
                    return new BadRequestObjectResult(result);
                }
                return Ok(new ApiOkResponse(result));
            }
            catch(CError e)
            {
                throw e;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
          


            //if (response == null)
            //    return NotFound(new ApiResponse(404, $"Error de login"));
            //else
            //    return Ok(new ApiOkResponse(_response));
        }
    }
}