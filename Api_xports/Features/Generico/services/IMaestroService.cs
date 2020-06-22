using Api_xports.Features.Generico.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_xports.Features.Generico.services
{
    /// <summary>
    /// Interface que representa el servicio de los maestros
    /// </summary>
    public interface IMaestroService
    {
        /// <summary>
        /// Retorno los tipo de personas
        /// </summary>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetTipoPersonas();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetRools();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="uicompany"></param>
        /// <param name="uideporte"></param>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetInstalaciones(string fecha, string uicompany, string uideporte);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uicompany"></param>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetUseSinRegistrar(string uicompany);
        ///Devuelve los tipos de reservas
        Task<List<ItemBaseResponse>> GetTipoReserva();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetTipoMovimiento();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidcompany"></param>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetFamiliaProducto(Guid uidcompany);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidfamilia"></param>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetProductosProducto(Guid uidfamilia);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<ItemBaseResponse>> GetMasterFormaDePago();
    }
}
