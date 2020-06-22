using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Recibos.DTO;
using Api_xports.Features.Recibos.DTO.Request;
using Api_xports.Features.Recibos.DTO.Response;
using Api_xports.Log;
using Domain.xports.Data.Models;
using Repository.DTO;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Api_xports.Features.Recibos.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class RecibosService : IRecibosService
    {
        private ILog _log;
        private readonly IStoreProcedureRepository _storeProcedure;
        private readonly IUnitOfWork _iunitOfWork;
        private readonly IErrorManager _errorManager;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iunitOfWork"></param>
        /// <param name="log"></param>
        /// <param name="storeProcedure"></param>
        /// <param name="errorManager"></param>
        public RecibosService(IUnitOfWork iunitOfWork,
             ILog log,
             IStoreProcedureRepository storeProcedure,
             IErrorManager errorManager)
        {
            _iunitOfWork = iunitOfWork;
            _log = log;
            _storeProcedure = storeProcedure;
            _errorManager = errorManager;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<RetornoProcedureDto> AddRecibos(ReciboRequest dto)
        {
            try {
                RetornoProcedureDto retorno = new RetornoProcedureDto();
                retorno = await _storeProcedure.XportsRecibosInsert(new ReciboRepositoryDto() { 
                    uiReserva = dto.uiReserva,
                    uidPerson = dto.uidPerson
                });
                return retorno;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("AddRecibos", "AddRecibos", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "AddRecibos", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<Company_Recibos_Detalle> AddLineaRecibo(LineaReciboRequest dto)
        {
            try
            {
                Company_Recibos_Detalle _entity = new Company_Recibos_Detalle();
                _entity.UID_Recibo = dto.uidRecibo;
                _entity.UID_Producto = dto.uidProducto;
                _entity.Descripcion = dto.descripcion;
                _entity.Importe_Unitario = dto.dcImporteUnitario;
                _entity.Unidades = dto.iUnidades;
                _entity.Importe_Total = _entity.Importe_Unitario.Value * _entity.Unidades;
                await _iunitOfWork.CompanyRecibosDetalleRepository.InsertEntity(_entity);
                await _iunitOfWork.CompanyRecibosDetalleRepository.SaverChangeAsyc();
                return _entity;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("AddRecibos", "AddLineaRecibo", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "AddLineaRecibo", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public async Task<RetornoProcedureDto> AddCajaMovimiento(CajaMovimientoRequest dto)
        {
            try
            {
                RetornoProcedureDto retorno = new RetornoProcedureDto();
                retorno = await _storeProcedure.XportsCajaMovimientoInsert(new LineaMovimientoRepositoryDto() { 
                    uidcompany = dto.uidcompany ,
                    uidFormaPago = dto.uidFormaPago,
                    uidRecibos = dto.uidRecibos,
                    uidUser = dto.uidUser,
                    uidTipoMovimiento = dto.uidTipoMovimiento
                });
                return retorno;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("AddRecibos", "AddRecibos", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "AddRecibos", ex, MethodBase.GetCurrentMethod(), null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidReserva"></param>
        /// <param name="uidPersona"></param>
        /// <returns></returns>
        public async Task<List<GetRecibosByUIDPersonRequest>> GetRecibosByUIDPerson(Guid uidReserva, Guid uidPersona)
        {
            List<GetRecibosByUIDPersonRequest> response = new List<GetRecibosByUIDPersonRequest>();
            try
            {
                var collection = await _storeProcedure.XportsGetRecibosByUIDPerson(new RecibosByPersonFilterRepository() { 
                    uidPersona = uidPersona,
                    uidReserva = uidReserva
                });
                foreach( var item in collection )
                {
                    response.Add(new GetRecibosByUIDPersonRequest() { 
                        uidReserva = item.uidReserva,
                        descripcion = item.descripcion,
                        dimportePagado = item.importePagado,
                        dimportePendiente = item.importePendiente,
                        dimporteTotal = item.importeTotal,
                        dimporteUnitario = item.importeUnitario,
                        dtotalRecibo = item.totalRecibo,
                        estadoRecibo = item.estadoRecibo,
                        fechaRecibo = item.fechaRecibo,
                        iunidades = item.unidades,
                        uidProducto = item.uidProducto,
                        uidProjectFase = item.uidProjectFase,
                        uidRecibo = item.uidRecibo
                    });
                }
                return response;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetRecibosByUIDPerson", "Recibos_GetRecibosByCompany", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("GetRecibosByUIDPerson", "Recibos_GetRecibosByCompany", ex, MethodBase.GetCurrentMethod(), null);
            }

        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidCompany"></param>
        /// <param name="uidPerson"></param>
        /// <param name="uidEstadoRecibo"></param>
        /// <returns></returns>
        public async Task<List<RecibosByUidComanyResponse>> GetRecibosByCompany(Guid uidCompany , Guid? uidPerson , Guid? uidEstadoRecibo )
        {
            List<RecibosByUidComanyResponse> response = new List<RecibosByUidComanyResponse>();
            try {
                var collection = (from recibos in _iunitOfWork.CompanyRecibosRepository.GetAllAsync().Result
                                  join estrecibo in _iunitOfWork.MasterEstadoReciboRepository.GetAllAsync().Result
                                  on recibos.UID_EstadoRecibo equals estrecibo.UID
                                  join person in _iunitOfWork.PersonPersonRepository.GetAllAsync().Result
                                  on recibos.UID_Person equals person.UID
                                  where recibos.UID_Company == uidCompany
                                  select new RecibosByCompany_Dto
                                  {
                                      uidRecibo = recibos.UID,
                                      uidPerson = recibos.UID_Person,
                                      uidEstadoRecibo = recibos.UID_EstadoRecibo.Value,
                                      dtFechaAlta = recibos.Fecha_Alta,
                                      dtFechaBaja = recibos.Fecha_Baja,
                                      dtFechaPago = recibos.FechaPago,
                                      estadoRecibo = estrecibo.Descripcion,
                                      ImportePagado = recibos.ImportePagado.Value,
                                      ImportePendiente = recibos.ImportePendiente.Value,
                                      ImporteTotal = recibos.ImporteTotal.Value,
                                      uidFormaPago = recibos.UID_FormaPago.Value,
                                      usuario = person.Nombre, 
                                  }).ToList();

                if (uidPerson != null)
                {
                    collection = collection.Where(x => x.uidPerson == uidPerson.Value).ToList();
                }
                if (uidEstadoRecibo != null)
                {
                    collection = collection.Where(x => x.uidEstadoRecibo == uidEstadoRecibo.Value).ToList();
                }

                foreach (var item in collection)
                {
                    string _formaPago = "";
                    if (item.uidFormaPago != null)
                    {
                        _formaPago = _iunitOfWork.MasterFormasPagoRepository.FindAsync(x => x.UID == item.uidFormaPago).Result.Descripcion;
                    }
                    response.Add(new RecibosByUidComanyResponse()
                    {
                        dtFechaAlta = item.dtFechaAlta,
                        dtFechaBaja = item.dtFechaBaja,
                        dtFechaPago = item.dtFechaPago,
                        estadoRecibo = item.estadoRecibo,
                        formaPago = _formaPago,
                        dcImportePagado = item.ImportePagado.Value,
                        dcImportePendiente = item.ImportePendiente.Value,
                        dcImporteTotal = item.ImporteTotal.Value,
                        uidRecibo = item.uidRecibo.Value,
                        usuario = item.usuario
                    });
                }
                // return response;

                return await Task.Run(() => response);
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetRecibosByCompany", "Recibos_GetRecibosByCompany", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Recibos_GetRecibosByCompany", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
    }
}
