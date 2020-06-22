using Domain.xports.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.interfaces
{
   public interface IUnitOfWork
    {
        IGenericDataRespositoryBase<UserToken, Guid> UserTokenRepository { get; }

        IGenericDataRespositoryBase<Master_Jerarquia_Menus,int> MasterJerarquiaMenusRepository { get; }

        IGenericDataRespositoryBase<AspNetUserRoles,string> NetUserRolesRepository { get; }
        IGenericDataRespositoryBase<Person_Person, int> PersonPersonRepository { get; }
        IGenericDataRespositoryBase<Master_TipoPersonal,Guid> MasterTipoPersonaRepository { get; }
        IGenericDataRespositoryBase<Security_User,Guid> SecurityUserRepository { get; }
        IGenericDataRespositoryBase<Master_TipoReserva,int> MasterTipoReserva {get;}
        IGenericDataRespositoryBase<Company_Caja_Movimientos, int> CajaMovimientoRepository { get; }
        IGenericDataRespositoryBase<Master_TipoMovimiento, int> MasterTipoMovimientoRepository { get; }
        IGenericDataRespositoryBase<Company_Caja, int> CompanyCajaRepository { get; }
        IGenericDataRespositoryBase<Instalaciones_Reserva_Lin, int> InstalacionesReservasLiRepository { get; }

        IGenericDataRespositoryBase<Productos_Familia, int> ProductoFamiliaRepository { get; }
        IGenericDataRespositoryBase<Productos_Producto, int> ProductoProductoRepository { get; }
        IGenericDataRespositoryBase<Master_FormasPago, int> MasterFormasPagoRepository { get; }

        IGenericDataRespositoryBase<Company_Recibos_Detalle, int> CompanyRecibosDetalleRepository { get; }

        IGenericDataRespositoryBase<Instalaciones_Reserva, int> InstalacionesReservasRepository { get; }

        IGenericDataRespositoryBase<Master_EstadoRecibo, int> MasterEstadoReciboRepository { get; }

        IGenericDataRespositoryBase<Company_Recibos, int> CompanyRecibosRepository { get; }
    }
}
