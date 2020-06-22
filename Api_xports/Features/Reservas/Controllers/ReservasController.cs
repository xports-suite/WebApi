using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.reservas.Services;
using Api_xports.Features.Reservas.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api_xports.Features.Reservas.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/reservas")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IReservasService _reservasSrv;
        /// <summary>
        /// Construtor de reservas
        /// </summary>
        /// <param name="reservasSrv"></param>
        public ReservasController(IReservasService reservasSrv)
        {
            _reservasSrv = reservasSrv;

        }

        /// <summary>
        /// Devuelve las instalaciones
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetEvents")]
        [SwaggerOperation(Summary = "Devuelve todas las instalaciones",
          Description = "Devuelve todas las instalaciones", 
            OperationId = "GetEvents")]
        public async Task<IActionResult> Events(string fecha,Guid uidCompany)
        {
            try
            {
                var retorno = await _reservasSrv.GetEventos(fecha, uidCompany.ToString());
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
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AddEvent")]
        [SwaggerOperation(Summary = "Añadir un evento",
         Description = "Añadir un evento",
           OperationId = "AddEvent")]
        public async Task<IActionResult> AddEvent([FromBody]EventoRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                var retorno = await _reservasSrv.RegistroEvento(request);
               
                if (retorno.berror) {
                    validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { retorno.msjError }));
                    return new BadRequestObjectResult(validationModel);
                }
                else
                {
                    return Ok(new ApiOkResponse(retorno.uidRetorno));
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
        [HttpPost("SetEvent")]
        [SwaggerOperation(Summary = "Modificar evento", Description = "Modificar evento", OperationId = "SetEvent")]
        public async Task<IActionResult> SetEvent([FromBody]EventoRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                var retorno = await _reservasSrv.RegistroEvento(request);

                if (retorno.berror)
                {
                    validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { retorno.msjError }));
                    return new BadRequestObjectResult(validationModel);
                }
                else
                {
                    return Ok(new ApiOkResponse(request));
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
        [HttpPost("deleteEvent")]
        [SwaggerOperation(Summary = "borrar evento",
         Description = "borrar evento",
           OperationId = "RegisterEvent")]
        public async Task<IActionResult> deleteEvent([FromBody]DeleteEventRequest request)
        {
            try
            {
                ValidationModel validationModel = new ValidationModel();
                if (request.uidReserva == Guid.Empty)
                {
                    validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { "falta parametro uidReserva" }));
                    return new BadRequestObjectResult(validationModel);
                }
                else
                {
                    var retorno = await _reservasSrv.RegistroDetele(request.uidReserva);
                    if(retorno != "0")
                    {
                        validationModel.ValidationResults.Add(new ValidationResult("-1", new[] { retorno }));
                        return new BadRequestObjectResult(validationModel);
                    }
                    else
                    {
                        return Ok(new ApiOkResponse("OK"));
                    }
                    
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

    }
}