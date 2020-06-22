using Api_xports.Features.Reservas.DTO.Request;
using Api_xports.Features.Reservas.DTO.Response;
using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.reservas.Services
{
    /// <summary>
    /// Interface que representa las acciones realacionadas con una reserva.
    /// </summary>
    public interface IReservasService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<EventosResponse> GetEventos(string fecha, string company);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        Task<RetornoProcedureDto> RegistroEvento(EventoRequest dto);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidReserva"></param>
        /// <returns></returns>
        Task<string> RegistroDetele(Guid uidReserva);
    }
}
