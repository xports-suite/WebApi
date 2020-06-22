using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Caja.DTO.Request;
using Api_xports.Features.Caja.DTO.Response;
using Api_xports.Features.Generico.DTO.Response;
using Api_xports.Log;
using Domain.xports.Data.Models;
using Newtonsoft.Json;
using Repository;
using Repository.DTO;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Api_xports.Features.Caja.services
{
   
    /// <summary>
    /// Controlador de servicio de caja
    /// </summary>
    public class CajaService : ICajaService
    {
        private ILog _log;
        private readonly IStoreProcedureRepository _storeProcedure;
        private readonly IUnitOfWork _iunitOfWork;
        private readonly IErrorManager _errorManager;
        private readonly MapperCaja _mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iunitOfWork"></param>
        /// <param name="log"></param>
        /// <param name="storeProcedure"></param>
        /// <param name="errorManager"></param>
        public CajaService(IUnitOfWork iunitOfWork,
             ILog log,
             IStoreProcedureRepository storeProcedure,
             IErrorManager errorManager)
        {
            _iunitOfWork = iunitOfWork;
            _log = log;
            _storeProcedure = storeProcedure;
            _errorManager = errorManager;
            _mapper = new MapperCaja();
        }

        #region Caja Movimiento
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<string> RegistroMovimiento(MovimientoRequest request)
        {
            try
            {
                Guid _Company = Guid.Empty;
                //Antes de llamar al procedimiento realizamos un inserccion en la tabla CajaMovimiento , 
                //Esto se hace ya que hay un trigerr en dicha tabla y se debe de lanzar
                if (request.uidtipoMovimiento.ToUpper() == "75F161D7-419E-4FD2-BB4C-88F5483752D9")
                {
                    Company_Caja dtoCompany = new Company_Caja();
                    dtoCompany.UID_Company = Guid.Parse(request.uicompany);
                    dtoCompany.Fecha = DateTime.Now;
                    dtoCompany.Importe_Apertura = request.importe;
                    await _iunitOfWork.CompanyCajaRepository.InsertEntity(dtoCompany);
                    await _iunitOfWork.CompanyCajaRepository.SaverChangeAsyc();
                    _Company = dtoCompany.UID;
                }
                else
                {
                    var companyCaja = _iunitOfWork.CompanyCajaRepository.FindAllAsync(x => x.UID_Company == Guid.Parse(request.uicompany) && x.Fecha <= DateTime.Now).Result.FirstOrDefault();
                    if (companyCaja != null)
                        _Company = companyCaja.UID;
                }
                if(_Company != Guid.Empty)
                {
                    await _iunitOfWork.CajaMovimientoRepository.InsertEntity(new Company_Caja_Movimientos()
                    {
                        Descripcion = request.descripcion,
                        Importe = request.importe,
                        UID_TipoMovimiento = Guid.Parse(request.uidtipoMovimiento),
                        UID_User = Guid.Parse(request.uiperson),
                        Fecha = DateTime.Now,
                        UID_Caja = _Company
                    });
                    await _iunitOfWork.CajaMovimientoRepository.SaverChangeAsyc();
                }
            }
            catch (CError e)
            {
                throw _errorManager.AddError("RegistroEvento", "Maestros_RegistroEvento", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                _log.Debug(ex.GetBaseException().ToString());
                throw _errorManager.AddError("Error Generico", "Maestros_RegistroEvento", ex, MethodBase.GetCurrentMethod(), null);
            }

            // return await Task.Run(() => "OK");
            return "OK";
        }
        /// <summary>
        /// Retorna los movimiento de caja de ese dia
        /// </summary>
        /// <param name="uidcompany"></param>
        /// <returns></returns>
        public async Task<List<CajaMovimientoResponse>> GetCajaMovimientos(string uidcompany)
        {
            List<CajaMovimientoResponse> response = new List<CajaMovimientoResponse>();
            try
            {
                var colectionCajaMovimientos = await _storeProcedure.XportsGetCajaMovimientosByUIDCompanyFecha(Guid.Parse(uidcompany));
                foreach(var cajamovimiento in colectionCajaMovimientos)
                    response.Add(_mapper.Parse(cajamovimiento));
                return response;
            }
            catch (CError e)
            {
                var sparameters = "uidCompany : " + uidcompany;
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("GetCajaMovimientos", "CajaService_GetCajaMovimientos", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var sparameters = "uidCompany : " + uidcompany;
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("Error Generico", "CajaService_GetCajaMovimientos", ex, MethodBase.GetCurrentMethod(), jsonModel);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<List<ItemBaseResponse>> GetTipoMovimiento(Guid uidcompany)
        {
            List<ItemBaseResponse> _respuesta = new List<ItemBaseResponse>();
            try
            {
                
                var collectionTipoMovimientos =  _iunitOfWork.MasterTipoMovimientoRepository.FindAllAsync(x => x.FormaPago == false).Result.ToList();
                //BUscamos si tenemos uidcompany para el movimiento apertura 
                var companyCaja = _iunitOfWork.CompanyCajaRepository.FindAllAsync(x => x.UID_Company == uidcompany && x.Fecha == DateTime.Now.Date).Result.FirstOrDefault();
                if(companyCaja != null)
                {
                    //Tenemos registro de apertura 
                    //Tendremos que quitar dicho tipo de movmiento sobre la collection
                    collectionTipoMovimientos = collectionTipoMovimientos.Where(x => x.UID != Guid.Parse("75F161D7-419E-4FD2-BB4C-88F5483752D9")).ToList();
                    //Recuperamos todos los registros de caja.movimientos sobre la UIDCAJA
                    var colectionMovimientosCaja = await _iunitOfWork.CajaMovimientoRepository.FindAllAsync(x => x.UID_Caja == companyCaja.UID);
                    // Si tenemos movimiento de cierre asignado no podremos registrar mas movimientos ese dia
                    var movientoCierra = colectionMovimientosCaja.Where(x => x.UID_TipoMovimiento == Guid.Parse("5537FFAD-4729-4773-AEEE-8CBE6B73FB62")).FirstOrDefault();
                    if(movientoCierra != null)
                    {
                        collectionTipoMovimientos = new List<Master_TipoMovimiento>();
                    }
                }
                else
                {
                    collectionTipoMovimientos = collectionTipoMovimientos.Where(x => x.UID == Guid.Parse("75F161D7-419E-4FD2-BB4C-88F5483752D9")).ToList();
                }

                foreach (var item in collectionTipoMovimientos)
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
        #endregion

        #region Caja Situacion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public async Task<List<CajaSituacionResponse>> GetCajaSituacion(DateTime fechaDesde  , DateTime fechaHasta)
        {
            List<CajaSituacionResponse> retorno = new List<CajaSituacionResponse>();
            try {
                var collectionSituacion = await _iunitOfWork.CompanyCajaRepository.FindAllAsync(x => x.Fecha >= fechaDesde && x.Fecha <= fechaHasta);
                foreach (var cajasituacion in collectionSituacion)
                    retorno.Add(_mapper.Parse(cajasituacion));
                return retorno;
            }
            catch (CError e)
            {
                var sparameters = "fechaDesde : " + fechaDesde.ToString() + "FechaHasta : " + fechaHasta.ToString();
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("GetCajaMovimientos", "CajaService_GetCajaMovimientos", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var sparameters = "fechaDesde : " + fechaDesde.ToString() + "FechaHasta : " + fechaHasta.ToString();
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("Error Generico", "CajaService_GetCajaMovimientos", ex, MethodBase.GetCurrentMethod(), jsonModel);

            }

        }
        #endregion
    }

    /// <summary>
    /// Clase de mapeos de la entidad de caja
    /// </summary>
    public class MapperCaja
    {
        /// <summary>
        /// Parse de entidades de Caja de Movimiento
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public CajaMovimientoResponse Parse(CajaMovimientosRepositoryDto dto)
        {
            CajaMovimientoResponse response = new CajaMovimientoResponse();
            IFormatProvider culture = new System.Globalization.CultureInfo("es-ES", true);
            response.dtInit = dto.Fecha.ToString("g",culture);
            response.formaDePago =  string.IsNullOrEmpty(dto.Forma_Pago) ? "" : dto.Forma_Pago.ToString();
            response.dcimporte = dto.Importe;
            response.tipoMovimiento = dto.Tipo_Movimiento;
            response.uidMovimiento = dto.UID_Movimiento;
            response.description = dto.Descripcion;
            return response;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public CajaSituacionResponse Parse(Company_Caja dto)
        {
            CajaSituacionResponse response = new CajaSituacionResponse();
            response.dtInit = dto.Fecha.Value;
            response.dcApertura = dto.Importe_Apertura == null ? 0 : dto.Importe_Apertura.Value;
            response.dcMetalico = dto.Importe_Metalico == null ? 0 : dto.Importe_Metalico.Value;
            response.dcTarjeta = dto.Importe_Tarjeta == null ? 0 : dto.Importe_Tarjeta.Value;
            response.dcRetirado = dto.Importe_Retirado == null ? 0 : dto.Importe_Retirado.Value;
            response.dcCierre = dto.Importe_Cierre == null ? 0 : dto.Importe_Cierre.Value;
            response.dcIngresos = dto.Importe_Ingresos == null ? 0 : dto.Importe_Ingresos.Value;
            response.dcPagos = dto.Importe_Pagos == null ? 0 : dto.Importe_Pagos.Value;
            response.dcDescuadre = dto.Importe_Descuadre == null ? 0 : dto.Importe_Descuadre.Value;
            return response;
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
    }
}
