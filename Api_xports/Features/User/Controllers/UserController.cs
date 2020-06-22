using System;
using System.Threading.Tasks;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.User.DTO.Request;
using Api_xports.Features.User.Services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api_xports.Features.User.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userSrv;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userSrv"></param>
        public UserController(IUserServices userSrv)
        {
            _userSrv = userSrv;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddUserApp")]
        [SwaggerOperation(Summary = "Crear Usuario App",Description = "Crear Usuario App", OperationId = "AddUserApp")]
        public async Task<IActionResult> CreateUser([FromBody]AddUserAppRequest request)
        {
            try
            {
                var retorno =  await _userSrv.AddUserApp(request);
                if (retorno.HasValidationErrors())
                {
                    return new BadRequestObjectResult(retorno);
                }
               return Ok(new ApiOkResponse(retorno));
            }
            catch(CError ce)
            {
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Modificacion de los registros de un usuario de app
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("SetUserApp")]
        [SwaggerOperation(
            Summary = "Modificacion usuario app", 
            Description = "Modificacion Usuario App",
            OperationId = "SetUserApp")]
        public async Task<IActionResult> SetUserApp([FromBody]SetUserAppRequest request)
        {

            try {
                var retorno = await _userSrv.SetUserApp(request);
                return Ok(new ApiOkResponse(retorno));
            }
            catch(CError ce)
            {
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddUser")]
        [SwaggerOperation(Summary = "Crear Usuario sin acceso a la aplicacion", Description = "Crear Usuario", OperationId = "AddUser")]
        public async Task<IActionResult> CrearUserApp([FromBody]AddUserRequest request)
        {
            try {
                var retorno = await _userSrv.AddUser(request);
                if (retorno.HasValidationErrors())
                {
                    return new BadRequestObjectResult(retorno);
                }
                return Ok(new ApiOkResponse(retorno));
            }
            catch (CError ce)
            {
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Modificamos un usuario de la aplicacion.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("SetUser")]
        [SwaggerOperation(Summary = "Modificamos un usuario", Description = "Modificamos un usuario", OperationId = "SetUser")]
        public async Task<IActionResult> SetUser([FromBody]SetUserRequest request)
        {
            try
            {
                var retorno = await _userSrv.SetUser(request);
                
                if (retorno.HasValidationErrors())
                {
                    return new BadRequestObjectResult(retorno);
                }
                return Ok(new ApiOkResponse(retorno));
            }
            catch (CError ce)
            {
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        [HttpGet("GetMenuUser")]
        [SwaggerOperation(Summary = "Menu por rol", Description = "Nos proporciona el menu en funcion del rol", OperationId = "GetMenuUser")]
        public async Task<IActionResult> GetMenuUser(string token)
        {
            try {
                var response = await _userSrv.GetMenuRol(token);
                return Ok(new ApiOkResponse(response));
            }
            catch(CError ce)
            {
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidCompany"></param>
        /// <param name="idMenu"></param>
        /// <returns></returns>
        [HttpGet("GetUsers")]
        [SwaggerOperation(
            Summary = "Usuarios xports", 
            Description = "Filtra los usuarios por compañia con la opcion de poder incluir el menu", 
            OperationId = "GetUsers")]
        public async Task<IActionResult> GetUsers(Guid uidCompany , string idMenu)
        {
            try {
                var response = await _userSrv.GetUsers(uidCompany, idMenu);
                return Ok(new ApiOkResponse(response));
                // return Ok(response);

            }
            catch(CError ce)
            {
                throw ce;
            }
            catch(System.Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Devuelve los registro de un usuario logado
        /// </summary>
        /// <param name="uiPerson"></param>
        /// <returns></returns>
        [HttpGet("GetUserApp")]
        [SwaggerOperation(
           Summary = "Usuario App",
           Description = "Devuelve un usuario con acceso a al app",
           OperationId = "GetUserApp")]
        public async Task<IActionResult> GetUserApp(Guid uiPerson)
        {
            try {
                var response = await _userSrv.GetUserApp(uiPerson);
                return Ok(new ApiOkResponse(response));
                // return Ok(response);
            }
            catch (CError ce)
            {
                throw ce;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

    }
}