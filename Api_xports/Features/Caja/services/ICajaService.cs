using Api_xports.Features.Caja.DTO.Request;
using Api_xports.Features.Caja.DTO.Response;
using Api_xports.Features.Generico.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Caja.services
{
    /// <summary>
    /// Creacion interface ICaja
    /// </summary>
    public interface ICajaService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<string> RegistroMovimiento(MovimientoRequest request);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidcompany"></param>
        /// <returns></returns>
        Task<List<CajaMovimientoResponse>> GetCajaMovimientos(string uidcompany);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        Task<List<CajaSituacionResponse>> GetCajaSituacion(DateTime fechaDesde, DateTime fechaHasta);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetTipoMovimiento(Guid uidcompany);
    }
}
