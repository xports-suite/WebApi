using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Generico.services;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System;

namespace Api_xports.Features.Generico.Controllers
{
    /// <summary>
    /// Controlador para devolver los valores maestros
    /// </summary>
    [Route("api/maestros")]
    [ApiController]
    public class MaestroController : ControllerBase
    {
        private readonly IMaestroService _maestroSrv;
        /// <summary>
        /// Controlador del maestro donde instaciamos los interfaces
        /// </summary>
        public MaestroController(IMaestroService maestroSrv)
        {
            _maestroSrv = maestroSrv;
        }
        /// <summary>
        /// Metodo del controlador que devuelve los tipo personas
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetTipoPersonas")]
        [SwaggerOperation(Summary = "Devuelve los tipo personas" , Description = "Devuelve los tipos persona" , OperationId = "TipoPersonas")]
        public async Task<IActionResult> GetTipoPersonas()
        {
            try {
                var retorno = await _maestroSrv.GetTipoPersonas();
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
        /// <returns></returns>
        [HttpGet("GetRools")]
        [SwaggerOperation(Summary = "Devuelve todos los roles", 
            Description = "Devuelve todos los roles", OperationId = "GetRools")]
        public async Task<IActionResult> GetRools()
        {
            try {
                var retorno = await _maestroSrv.GetRools();
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
        /// Retorna las instalaciones 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetInstalaciones")]
        [SwaggerOperation(Summary = "Devuelve las instalaciones",
            Description = "Devuelve las instalaciones en funcion de la fecha , deporte y compañia",
            OperationId = "GetInstalaciones")]
        public async Task<IActionResult> GetInstalaciones(string fecha , string uiddeporte , string uidCompany)
        {
            try {
                var retorno = await _maestroSrv.GetInstalaciones(fecha, uiddeporte, uidCompany);
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
        /// Devuelve los tipos de reservas
        [HttpGet("GetTipoReservas")]
         [SwaggerOperation(Summary = "Devuelve los tipo de reservas",
            Description = "Devuelve los tipo de reservas",
            OperationId = "GetTipoReservas")]
        public async Task<IActionResult> GetTipoReservas(){
            try { 
                var retorno = await _maestroSrv.GetTipoReserva();
                return  Ok(new ApiOkResponse(retorno));
            }
            catch(CError ce) {
                 throw ce;
            }
            catch(System.Exception ex) {
                throw ex;
            }
        }
        /// Devuelve los tipos de reservas
        [HttpGet("GetTipoMovimientos")]
        [SwaggerOperation(Summary = "Devuelve los tipo de movimientos",
            Description = "Devuelve los tipo de movimientos",
            OperationId = "GetTipoMovimientos")]
        public async Task<IActionResult> GetTipoMovimientos()
        {
            try
            {
                var retorno = await _maestroSrv.GetTipoMovimiento();
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
        /// <param name="uidCompany"></param>
        /// <returns></returns>
        [HttpGet("GetUserWithoutRegister")]
        [SwaggerOperation(Summary = "Devuelve los usuarios sin registrar",
            Description = "Devuelve los usuarios sin registrar en la plataforma",
            OperationId = "GetUserWithoutRegister")]
        public async Task<IActionResult> GetUserWithoutRegister(string uidCompany)
        {
            try
            {
                var retorno = await _maestroSrv.GetUseSinRegistrar(uidCompany);
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
        /// <param name="uidCompany"></param>
        /// <returns></returns>
        [HttpGet("GetProductoFamilia")]
        [SwaggerOperation(Summary = "Productos Familia",
            Description = "Devuelve los productos familia pasando un compañia",
            OperationId = "GetProductoFamilia")]
        public async Task<IActionResult> GetProductoFamilia(Guid uidCompany)
        {
            try
            {
                var retorno = await _maestroSrv.GetFamiliaProducto(uidCompany);
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
        /// <param name="uidFamilia"></param>
        /// <returns></returns>
        [HttpGet("GetProductosProducto")]
        [SwaggerOperation(Summary = "Productos Producto",
            Description = "Devuelve los productos producto pasando un compañia",
            OperationId = "GetProductosProducto")]
        public async Task<IActionResult> GetProductosProducto(Guid uidFamilia)
        {
            try
            {
                var retorno = await _maestroSrv.GetProductosProducto(uidFamilia);
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
        /// <param name="uidFamilia"></param>
        /// <returns></returns>
        [HttpGet("GetFormaDePago")]
        [SwaggerOperation(Summary = "Formas de pago",
            Description = "Devuelve las formas de pago",
            OperationId = "GetFormaDePago")]
        public async Task<IActionResult> GetFormaDePago()
        {
            try
            {
                var retorno = await _maestroSrv.GetMasterFormaDePago();
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


        #region Private function
        #endregion

    }
}