using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Recibos.DTO.Request;
using Api_xports.Features.Recibos.Services;
using Api_xports.Features.reservas.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api_xports.Features.Recibos.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/recibos")]
    [ApiController]
    public class RecibosController : ControllerBase
    {
        private readonly IRecibosService _recibosSrv;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="recibosSrv"></param>
        public RecibosController(IRecibosService recibosSrv)
        {
            _recibosSrv = recibosSrv;
        }

        [HttpPost("recibo")]
        [SwaggerOperation(Summary = "Registramos un recibo",
        Description = "Registramos un recibo",
          OperationId = "Recibo")]
        public async Task<IActionResult> AddRecibos([FromBody]ReciboRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                var retorno = await _recibosSrv.AddRecibos(request);

                if (retorno.berror)
                {
                    validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { retorno.msjError }));
                    return new BadRequestObjectResult(validationModel);
                }
                else
                {
                    return Ok(new ApiOkResponse("OK"));
                }

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
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddLineaDetalle")]
        [SwaggerOperation(Summary = "Añade Linea Detalle",
        Description = "Añade Linea Detalle",
          OperationId = "AddLineaDetalle")]
        public async Task<IActionResult> AddLineaDetalle([FromBody]LineaReciboRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                var retorno = await _recibosSrv.AddLineaRecibo(request);
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
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddCajaMovimiento")]
        [SwaggerOperation(Summary = "Añade Caja Movimiento",
        Description = "Añade Caja Movimiento",
          OperationId = "AddCajaMovimiento")]
        public async Task<IActionResult> AddCajaMovimiento([FromBody]CajaMovimientoRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                var retorno = await _recibosSrv.AddCajaMovimiento(request);
                if (retorno.berror)
                {
                    validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { retorno.msjError }));
                    return new BadRequestObjectResult(validationModel);
                }
                else
                {
                    return Ok(new ApiOkResponse("OK"));
                }
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
        /// Devuelve las instalaciones
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetRecibosByUIDPerson")]
        [SwaggerOperation(Summary = "Devuelve el detalle del recibo",
          Description = "Devuelve el detalle del recibo",
            OperationId = "GetRecibosByUIDPerson")]
        public async Task<IActionResult> GetRecibosByUIDPerson(Guid uidReserva, Guid uidPersona)
        {
            try
            {
                var retorno = await _recibosSrv.GetRecibosByUIDPerson(uidReserva, uidPersona);
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
        /// Devuelve las instalaciones
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetRecibosCompany")]
        [SwaggerOperation(Summary = "Devuelve el detalle del recibo",
          Description = "Devuelve el detalle del recibo",
            OperationId = "GetRecibosCompany")]
        public async Task<IActionResult> GetRecibosCompany(Guid uidCompany, Guid? uidPerson, Guid? estadoRecibo)
        {
            try
            {
                var retorno = await _recibosSrv.GetRecibosByCompany(uidCompany, uidPerson , estadoRecibo);
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