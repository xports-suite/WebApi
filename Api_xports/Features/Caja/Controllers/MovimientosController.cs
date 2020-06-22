using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Caja.DTO.Request;
using Api_xports.Features.Caja.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api_xports.Features.Caja.Controllers
{
    /// <summary>
    /// Controlador caja - movmientos
    /// </summary>
    [Route("api/caja")]
    [ApiController]
    public class MovimientosController : ControllerBase
    {
        private readonly ICajaService _cajaSrv;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cajaSrv"></param>
        public MovimientosController(ICajaService cajaSrv)
        {
            _cajaSrv = cajaSrv;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("RegisterMovimiento")]
        [SwaggerOperation(Summary = "Registro Movimiento",
         Description = "Registro Movimiento",
           OperationId = "RegisterMovimiento")]
        public async Task<IActionResult> RegisterMovimiento([FromBody]MovimientoRequest request)
        {
            try
            {
                var retonro = await _cajaSrv.RegistroMovimiento(request);
                return Ok(new ApiOkResponse("OK"));
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
        /// <param name="guid"></param>
        /// <returns></returns>
        [HttpGet("GetMovimientoCaja")]
        [SwaggerOperation(Summary = "Devuevle los movimientos de una caja",
            Description = "Devuelve los movimientos de una caja en funcion de la fecha del dia que se realiza la petición y la compañia que se pasa",
            OperationId = "GetMovimientoCaja")]
        public async Task<IActionResult> GetMovimientoCaja(Guid guid)
        {
            try
            {
                var retorno = await _cajaSrv.GetCajaMovimientos(guid.ToString());
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
         /// <param name="fechaDesde"></param>
         /// <param name="fechaHasta"></param>
         /// <returns></returns>
        [HttpGet("GetCajaSituacion")]
        [SwaggerOperation(Summary = "Devuelve los resgistro de la caja",
            Description = "",
            OperationId = "")]
        public async Task<IActionResult> GetCajaSituacion(string fechaDesde , string fechaHasta)
        {
            try
            {
                var retorno = await _cajaSrv.GetCajaSituacion(DateTime.Parse(fechaDesde), DateTime.Parse(fechaHasta));
                return Ok(retorno);
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

        /// Devuelve los tipos de reservas
        [HttpGet("GetTipoMovimientos")]
        [SwaggerOperation(Summary = "Devuelve los tipo de movimientos",
            Description = "Devuelve los tipo de movimientos",
            OperationId = "GetTipoMovimientos")]
        public async Task<IActionResult> GetTipoMovimientos(Guid uidcomany)
        {
            try
            {
                var retorno = await _cajaSrv.GetTipoMovimiento(uidcomany);
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
    }
}