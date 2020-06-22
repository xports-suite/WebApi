using Api_xports.Features.Recibos.DTO;
using Api_xports.Features.Recibos.DTO.Request;
using Api_xports.Features.Recibos.DTO.Response;
using Domain.xports.Data.Models;
using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.Services
{
    
    public interface IRecibosService
    {
        Task<RetornoProcedureDto> AddRecibos(ReciboRequest dto);
        Task<Company_Recibos_Detalle> AddLineaRecibo(LineaReciboRequest dto);
        Task<RetornoProcedureDto> AddCajaMovimiento(CajaMovimientoRequest dto);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidReserva"></param>
        /// <param name="uidPersona"></param>
        /// <returns></returns>
        Task<List<GetRecibosByUIDPersonRequest>> GetRecibosByUIDPerson(Guid uidReserva, Guid uidPersona);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidCompany"></param>
        /// <param name="uidPerson"></param>
        /// <param name="uidEstadoRecibo"></param>
        /// <returns></returns>
        Task<List<RecibosByUidComanyResponse>> GetRecibosByCompany(Guid uidCompany, Guid? uidPerson, Guid? uidEstadoRecibo);
    }
}
