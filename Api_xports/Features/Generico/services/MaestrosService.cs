using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Generico.DTO.Response;
using Api_xports.Log;
using Domain.Identity;
using Domain.xports.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Repository.DTO;
namespace Api_xports.Features.Generico.services
{
    /// <summary>
    /// Servicio que nos devolvera los datos maestros
    /// </summary>
    public class MaestrosService : IMaestroService
    {
        private readonly ILog _log;
        private readonly IConfiguration _configuration;
        private readonly IErrorManager _errorManager;
        private readonly IUnitOfWork _unitOfWork;
        private readonly RoleManager<ApplicationRoles> _roleManager;
        private readonly MapperMaestros _mapper;
        private readonly IStoreProcedureRepository _storeProcedureRespository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="configuration"></param>
        /// <param name="errorManager"></param>
        /// <param name="log"></param>
        /// <param name="roleManager"></param>
        /// <param name="storeProcedureRespository"></param>
        public MaestrosService(IUnitOfWork unitOfWork,
            IConfiguration configuration,
            IErrorManager errorManager,
            ILog log,
            RoleManager<ApplicationRoles> roleManager,
            IStoreProcedureRepository storeProcedureRespository)
        {
            _unitOfWork = unitOfWork;
            _storeProcedureRespository = storeProcedureRespository;
            _configuration = configuration;
            _errorManager = errorManager;
            _log = log;
            _roleManager = roleManager;
            _mapper = new MapperMaestros();


        }
        /// <summary>
        /// Retorno los registros sobre el maestro de TiposPersona
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetTipoPersonas()
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var result = await _unitOfWork.MasterTipoPersonaRepository.GetAllAsync();
                foreach (var item in result)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoPersonas", "Maestros_GetTipoPersona", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Maestros_GetTipoPersona", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetRools()
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var result = _roleManager.Roles.ToList().OrderBy(x => x.NormalizedName);
                foreach (var item in result)
                    _respuesta.Add(_mapper.Parse(item));
                return await Task.Run(() => _respuesta);
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoPersonas", "Maestros_GetTipoPersona", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Maestros_GetTipoPersona", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="uicompany"></param>
        /// <param name="uideporte"></param>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetInstalaciones(string fecha , string uideporte , string uicompany )
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();

            try {
                var instalaciones = await _storeProcedureRespository.XportsGetInstalation(
                    new ReservaFilterRepositoryDto() { 
                        fecha = DateTime.Parse(fecha),
                        uid_company = Guid.Parse(uicompany),
                        uid_deporte = Guid.Parse(uideporte)
                    });
                foreach (var item in instalaciones)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;

            }
            catch(CError e)
            {
                throw _errorManager.AddError("GetInstalaciones", "Maestros_GetInstalaciones", e, MethodBase.GetCurrentMethod(), null);
            }
            catch(System.Exception ex)
            {
                throw _errorManager.AddError("Error GetInstalaciones", "Maestros_GetInstalaciones", ex, MethodBase.GetCurrentMethod(), null);
            }
        }

      /// <summary>
      /// 
      /// </summary>
      /// <param name="uicompany"></param>
      /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetUseSinRegistrar(string uicompany)
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();

            try
            {
                var colletionUser = await _storeProcedureRespository.XportsGetUserPerson(new UserFilterRepository_Dto()
                {
                    IdMenu = 3,
                    UID_Company = Guid.Parse(uicompany)
                });
                foreach (var item in colletionUser)
                    _respuesta.Add(_mapper.Parse(item));

                return _respuesta;

            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetInstalaciones", "Maestros_GetInstalaciones", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetInstalaciones", "Maestros_GetInstalaciones", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// Devuelve todas las reservas.
        public async Task<List<ItemBaseResponse>> GetTipoReserva() {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try{
                var collectionTipoReserva = await _unitOfWork.MasterTipoReserva.FindAllAsync(x => x.Activo == true);
                foreach( var item in collectionTipoReserva)
                _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch(CError e) {
                throw _errorManager.AddError("GetTipoReserva", "Maestros_GetTipoReserva", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetTipoReserva", "Maestros_GetTipoReserva", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// <summary>
        /// Devuelve los tipo de movimiento
        /// </summary>
        /// <returns></returns>

        public async Task<List<ItemBaseResponse>> GetTipoMovimiento()
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var collectionTipoReserva = await _unitOfWork.MasterTipoMovimientoRepository.FindAllAsync(x => x.FormaPago == false);
                foreach (var item in collectionTipoReserva)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoReserva", "Maestros_GetTipoReserva", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetTipoReserva", "Maestros_GetTipoReserva", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidcompany"></param>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetFamiliaProducto(Guid uidcompany)
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var collectionTipoReserva = await _unitOfWork.ProductoFamiliaRepository.FindAllAsync(x => x.UID_COMPANY == uidcompany && x.Activo == true);
                foreach (var item in collectionTipoReserva)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoReserva", "Maestros_GetTipoReserva", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetTipoReserva", "Maestros_GetTipoReserva", ex, MethodBase.GetCurrentMethod(), null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidfamilia"></param>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetProductosProducto(Guid uidfamilia)
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var collectionTipoReserva = await _unitOfWork.ProductoProductoRepository.FindAllAsync(x => x.UID_Familia == uidfamilia && x.Activo == true);
                foreach (var item in collectionTipoReserva)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoReserva", "Maestros_GetTipoReserva", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetTipoReserva", "Maestros_GetTipoReserva", ex, MethodBase.GetCurrentMethod(), null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetMasterFormaDePago()
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                var collectionTipoReserva = await _unitOfWork.MasterFormasPagoRepository.FindAllAsync(x => x.Activo == true);
                foreach (var item in collectionTipoReserva)
                    _respuesta.Add(_mapper.Parse(item));
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetTipoReserva", "Maestros_GetTipoReserva", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error GetTipoReserva", "Maestros_GetTipoReserva", ex, MethodBase.GetCurrentMethod(), null);
            }
        }



        #region Private function


        #endregion




        /// <summary>
        /// Clase que mapea los maestros
        /// </summary>
        public class MapperMaestros
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="source"></param>
            /// <returns></returns>
            public ItemBaseResponse Parse(Master_TipoPersonal source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="source"></param>
            /// <returns></returns>
            public ItemBaseResponse Parse(ApplicationRoles source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = Guid.Parse(source.Id);
                _dto.Name = source.Name;
                return _dto;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="source"></param>
            /// <returns></returns>
            public ItemBaseResponse Parse(InstalacionRespositoryDto source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.uid_instalacion;
                _dto.Name = source.nombre;
                return _dto;
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="source"></param>
            /// <returns></returns>
            public ItemBaseResponse Parse(UsuarioRespository_Dto source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID_Person;
                _dto.Name = source.NombreCompleto;
                return _dto;
            }
            /// Parse un objeto de tipo ItemBaseRespose en funcion de MasterTipoReserva
            public ItemBaseResponse Parse(Master_TipoReserva source){
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }
            /// <summary>
            /// Parse un objecto de tipo ItemBaseRepositorio en MasterTipoMovimiento
            /// </summary>
            /// <param name="source"></param>
            /// <returns></returns>
            public ItemBaseResponse Parse(Master_TipoMovimiento source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }

            public ItemBaseResponse Parse(Productos_Familia source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }

            public ItemBaseResponse Parse(Productos_Producto source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }

            public ItemBaseResponse Parse(Master_FormasPago source)
            {
                ItemBaseResponse _dto = new ItemBaseResponse();
                _dto.Id = source.UID;
                _dto.Name = source.Descripcion;
                return _dto;
            }
        }
    }
}
