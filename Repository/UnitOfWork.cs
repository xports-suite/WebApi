using Domain.xports.Data.Models;
using Repository.interfaces;
using System;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private xports_devContext _context;
        private IGenericDataRespositoryBase<UserToken, Guid> _userTokenRepository;
        private IGenericDataRespositoryBase<Master_Jerarquia_Menus, int> _masterJerarquiaMenus;
        private IGenericDataRespositoryBase<AspNetUserRoles, string> _netUserRolesRepository;
        private IGenericDataRespositoryBase<Person_Person, int> _personPersonRepository;
        private IGenericDataRespositoryBase<Master_TipoPersonal, Guid> _masterTipoPersonaRepository;
        private IGenericDataRespositoryBase<Security_User, Guid> _securityUserReposotory;
        private IGenericDataRespositoryBase<Master_TipoReserva,int> _masterTipoReservaRepository;
        private IGenericDataRespositoryBase<Company_Caja_Movimientos, int> _cajaMovimientoRepository;
        private IGenericDataRespositoryBase<Master_TipoMovimiento, int> _masterTipoMovimiento;
        private IGenericDataRespositoryBase<Company_Caja, int> _companyCaja;
        private IGenericDataRespositoryBase<Instalaciones_Reserva_Lin , int> _instalacionesReservasLiRepository;
        private IGenericDataRespositoryBase<Productos_Familia, int> _productosFamiliaRepository;
        private IGenericDataRespositoryBase<Productos_Producto, int> _productosProductosRepository;
        private IGenericDataRespositoryBase<Master_FormasPago, int> _masterFormasPagoRepository;
        private IGenericDataRespositoryBase<Company_Recibos_Detalle, int> _companyReciboDetalleRepository;
        private IGenericDataRespositoryBase<Instalaciones_Reserva, int> _instalacionesReservasRepository;
        private IGenericDataRespositoryBase<Master_EstadoRecibo, int> _masterEstadoReciboRepository;
        private IGenericDataRespositoryBase<Company_Recibos, int> _companyRecibosRepository;

        public UnitOfWork(xports_devContext context)
        {
            _context = context;
        }

        public IGenericDataRespositoryBase<UserToken, Guid> UserTokenRepository
        {
            get
            {
                return _userTokenRepository = _userTokenRepository ?? new GenericDataRespositoryBase<UserToken, Guid>(_context);
            }
        }

        public IGenericDataRespositoryBase<Master_Jerarquia_Menus, int> MasterJerarquiaMenusRepository
        {
            get
            {
                return _masterJerarquiaMenus = _masterJerarquiaMenus ?? new GenericDataRespositoryBase<Master_Jerarquia_Menus, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<AspNetUserRoles, string> NetUserRolesRepository
        {
            get
            {
                return _netUserRolesRepository = _netUserRolesRepository ?? new GenericDataRespositoryBase<AspNetUserRoles, string>(_context);
            }
        }

        public IGenericDataRespositoryBase<Person_Person, int> PersonPersonRepository
        {
            get
            {
                return _personPersonRepository = _personPersonRepository ?? new GenericDataRespositoryBase<Person_Person, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Master_TipoPersonal, Guid> MasterTipoPersonaRepository
        {
            get
            {
                return _masterTipoPersonaRepository = _masterTipoPersonaRepository ?? new GenericDataRespositoryBase<Master_TipoPersonal, Guid>(_context);
            }
        }

        public IGenericDataRespositoryBase<Security_User, Guid> SecurityUserRepository
        {
            get
            {
                return _securityUserReposotory = _securityUserReposotory ?? new GenericDataRespositoryBase<Security_User, Guid>(_context);
            }
        }
        public IGenericDataRespositoryBase<Master_TipoReserva, int> MasterTipoReserva {
            get {
                return _masterTipoReservaRepository = _masterTipoReservaRepository ?? new GenericDataRespositoryBase<Master_TipoReserva,int>(_context);
            }

        }

        public IGenericDataRespositoryBase<Company_Caja_Movimientos, int> CajaMovimientoRepository
        {
            get
            {
                return _cajaMovimientoRepository = _cajaMovimientoRepository ?? new GenericDataRespositoryBase<Company_Caja_Movimientos, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Master_TipoMovimiento, int> MasterTipoMovimientoRepository
        {
            get
            {
                return _masterTipoMovimiento = _masterTipoMovimiento ?? new GenericDataRespositoryBase<Master_TipoMovimiento, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Company_Caja, int> CompanyCajaRepository
        {
            get
            {
                return _companyCaja = _companyCaja ?? new GenericDataRespositoryBase<Company_Caja, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Instalaciones_Reserva_Lin, int> InstalacionesReservasLiRepository
        {
            get
            {
                return _instalacionesReservasLiRepository = _instalacionesReservasLiRepository ?? new GenericDataRespositoryBase<Instalaciones_Reserva_Lin, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Productos_Familia, int> ProductoFamiliaRepository
        {
            get
            {
                return _productosFamiliaRepository = _productosFamiliaRepository ?? new GenericDataRespositoryBase<Productos_Familia, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Productos_Producto, int> ProductoProductoRepository
        {
            get
            {
                return _productosProductosRepository = _productosProductosRepository ?? new GenericDataRespositoryBase<Productos_Producto, int>(_context);
            }
        }
        public IGenericDataRespositoryBase<Master_FormasPago, int> MasterFormasPagoRepository
        {
            get
            {
                return _masterFormasPagoRepository = _masterFormasPagoRepository ?? new GenericDataRespositoryBase<Master_FormasPago, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Company_Recibos_Detalle, int> CompanyRecibosDetalleRepository
        {
            get
            {
                return _companyReciboDetalleRepository = _companyReciboDetalleRepository ?? new GenericDataRespositoryBase<Company_Recibos_Detalle, int>(_context);
            }
        }
        public IGenericDataRespositoryBase<Instalaciones_Reserva, int> InstalacionesReservasRepository
        {
            get
            {
                return _instalacionesReservasRepository = _instalacionesReservasRepository ?? new GenericDataRespositoryBase<Instalaciones_Reserva, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Master_EstadoRecibo, int> MasterEstadoReciboRepository
        {
            get
            {
                return _masterEstadoReciboRepository = _masterEstadoReciboRepository ?? new GenericDataRespositoryBase<Master_EstadoRecibo, int>(_context);
            }
        }

        public IGenericDataRespositoryBase<Company_Recibos, int> CompanyRecibosRepository
        {
            get
            {
                return _companyRecibosRepository = _companyRecibosRepository ?? new GenericDataRespositoryBase<Company_Recibos, int>(_context);
            }
        }
    }
}
