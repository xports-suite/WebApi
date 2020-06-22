using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Reservas.DTO.Request;
using Api_xports.Features.Reservas.DTO.Response;
using Api_xports.Log;
using Repository.DTO;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Api_xports.Features.reservas.Services
{
    /// <summary>
    /// Clase realaccionada con las reservas de pistas
    /// </summary>
    public class ReservasService : IReservasService
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
        public ReservasService(IUnitOfWork iunitOfWork ,
             ILog log ,
             IStoreProcedureRepository storeProcedure,
             IErrorManager errorManager
            )
        {
            _iunitOfWork = iunitOfWork;
            _log = log;
            _storeProcedure = storeProcedure;
            _errorManager = errorManager;

        }

        /// <summary>
        /// Devuelve las instalaciones 
        /// </summary>
        /// <returns></returns>
        public async Task<EventosResponse> GetEventos(string fecha , string uidCompany)
        {
            EventosResponse _response = new EventosResponse();
            try
            {
                if (!string.IsNullOrEmpty(fecha) && (!string.IsNullOrEmpty(uidCompany)))
                {
                    DateTime dtfecha = new DateTime();
                    dtfecha = DateTime.Parse(fecha);
                    ReservaFilterRepositoryDto _filter = new ReservaFilterRepositoryDto();
                    _filter.fecha = dtfecha;
                    _filter.uid_company = Guid.Parse(uidCompany);
                    _filter.uid_deporte = Guid.Parse("00437B42-A6C5-4079-A47C-FF71C7853B63");
                    _response = await searchEventsAsync(_filter);
                }
                return _response;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetInstalaciones", "Maestros_GetInstalaciones", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Maestros_GetInstalaciones", ex, MethodBase.GetCurrentMethod(), null);
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        public async Task<RetornoProcedureDto> RegistroEvento(EventoRequest dto)
        {
            try {
                DateTime dtinicio = DateTime.Parse(dto.start);
                DateTime dtfin = DateTime.Parse(dto.end);
                TimeSpan timeStrat = TimeSpan.Parse(dto.startTime);
                TimeSpan timeEnd = TimeSpan.Parse(dto.endTime);
                RetornoProcedureDto retorno = new RetornoProcedureDto();
                if (string.IsNullOrEmpty(dto.uiReserva))
                {
                    retorno = await _storeProcedure.XportsInstalacionesReservaInsert(new ReservaRepositoryDto()
                    {
                        // Titulo = dto.Titulo,
                        dt_inicio = new DateTime(dtinicio.Year, dtinicio.Month, dtinicio.Day, timeStrat.Hours, timeStrat.Minutes, 0),
                        dt_fin = new DateTime(dtfin.Year, dtfin.Month, dtfin.Day, timeEnd.Hours, timeEnd.Minutes, 0),
                        UID_Instalacion = Guid.Parse(dto.uidInstalacion.ToString()),
                        UID_Person_Reserva = dto.uidGroupUsers[0].uidPerson,
                        UID_TipoReserva = Guid.Parse(dto.uidTipoReserva.ToString()),
                        uidGropusUser = getCollectionSplitUser(dto.uidGroupUsers),
                        idPaymentPartsUsers = getCollectionSplitPaymentUser(dto.uidGroupUsers)
                    });
                }
                else
                {
                    ReservaRepositoryDto _dtoUpdate = new ReservaRepositoryDto();
                    _dtoUpdate.UID_Reserva = Guid.Parse(dto.uiReserva);
                    // _dtoUpdate.Titulo = dto.Titulo;
                    _dtoUpdate.UID_TipoReserva = Guid.Parse(dto.uidTipoReserva);
                    _dtoUpdate.dt_inicio = new DateTime(dtinicio.Year, dtinicio.Month, dtinicio.Day, timeStrat.Hours, timeStrat.Minutes, 0);
                    _dtoUpdate.dt_fin = new DateTime(dtfin.Year, dtfin.Month, dtfin.Day, timeEnd.Hours, timeEnd.Minutes, 0);
                    _dtoUpdate.UID_Instalacion = Guid.Parse(dto.uidInstalacion.ToString());
                    _dtoUpdate.UID_Person_Reserva = dto.uidGroupUsers[0].uidPerson;
                    _dtoUpdate.uidGropusUser = getCollectionSplitUser(dto.uidGroupUsers);
                    _dtoUpdate.idPaymentPartsUsers = getCollectionSplitPaymentUser(dto.uidGroupUsers);
                    retorno = await _storeProcedure.XportsInstalacionesReservaUpdate(_dtoUpdate);
                }
                return retorno;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("RegistroEvento", "Maestros_RegistroEvento", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Maestros_RegistroEvento", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidReserva"></param>
        /// <returns></returns>
        public async Task<string> RegistroDetele(Guid uidReserva)
        {
            try
            {
                var reserva = await _iunitOfWork.InstalacionesReservasRepository.FindAsync(x => x.UID == uidReserva);
                if(reserva != null)
                {
                    reserva.FechaAnulacion = DateTime.Now;
                    reserva.Activo = false;
                    await _iunitOfWork.InstalacionesReservasRepository.UpdateAsync(reserva);
                    // _log.Debug(delete.ToString());
                    return "0";
                }
                else
                {
                    _log.Debug("No borra");
                    return "No existe reserva con el identificador : " + uidReserva.ToString();
                }
                
                
            }
            catch (CError e)
            {
                throw _errorManager.AddError("RegistroEvento", "Maestros_RegistroEvento", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "Maestros_RegistroEvento", ex, MethodBase.GetCurrentMethod(), null);
            }
        }





        #region Instalaciones
        private async Task<EventosResponse> searchEventsAsync(ReservaFilterRepositoryDto filter)
        {

            var instalacions = await _storeProcedure.XportsGetInstalation(filter);
            var eventos = await _storeProcedure.XportsGetReservasByUIDCompany(filter);
            EventosResponse _respuesta = new EventosResponse();
            try {
                foreach (var inst in instalacions)
                    _respuesta.Instalaciones.Add(new InstalacionResponse()
                    {
                        id = inst.uid_instalacion.ToString(),
                        name = inst.nombre,
                        color = "#ad2121"
                    });

                foreach (var even in eventos)
                {
                    EventoResponse eventResponse = new EventoResponse();
                    eventResponse.uid_reserva = even.uid_reserva.ToString();
                    eventResponse.idinstalacion = even.num_instalacion;
                    eventResponse.uid_instalacion = even.uid_instalacion.ToString();
                    eventResponse.start = (even.Fecha + TimeSpan.Parse(even.Hora_inicio));
                    eventResponse.end = (even.Fecha + TimeSpan.Parse(even.Hora_fin));
                    eventResponse.uid_person = even.uid_Person.ToString();
                    // eventResponse.title = even.detalle;
                    eventResponse.nombreReserva = even.Nombre_Reserva;
                    eventResponse.colorReserva = even.color_reserva;
                    eventResponse.uidGroupUsers = GetCollectionGroupUsers(even.uid_reserva);
                    // eventResponse.uidGroupUsers = string.IsNullOrEmpty(even.UID_Todos_Usuarios) ? new List<string>() : even.UID_Todos_Usuarios.Split(";").ToList();
                    // eventResponse.idPaymentPartsUsers = getCollectionPaymentUser(even.Todos_Unidades);
                    eventResponse.uid_tipoReserva = even.UID_Tipo_Reserva.ToString();
                    _respuesta.Eventos.Add(eventResponse);
                }
                return _respuesta;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetInstalaciones", "searchEventsAsync", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "searchEventsAsync", ex, MethodBase.GetCurrentMethod(), null);
            }
            
          
        }
        private List<GroupUsers> GetCollectionGroupUsers(Guid uidReserva)
        {
            List<GroupUsers> retorno = new List<GroupUsers>();
            try {
                var collection = _iunitOfWork.InstalacionesReservasLiRepository.FindAllAsync(x => x.UID_Reserva == uidReserva).Result.OrderBy(x=>x.Orden);
               
                foreach(var instalationLin in collection)
                {
                    if(instalationLin.UID_Person != null)
                    {
                        GroupUsers _dto = new GroupUsers();

                        if (instalationLin.UID_Recibo == null)
                        {
                            _dto.StatusBill = 0;
                        }
                        else
                        {
                            if (instalationLin.Pagado == false)
                                _dto.StatusBill = 1;
                            else
                                _dto.StatusBill = 2;
                        }
                        _dto.orden = instalationLin.Orden;
                        _dto.uidPerson = instalationLin.UID_Person.Value;
                        _dto.unidades = instalationLin.Unidades == null ? 0 : instalationLin.Unidades.Value;
                        _dto.nombre = GetNombrePerson(instalationLin.UID_Person.Value);
                        retorno.Add(_dto);


                    }
                }
                return retorno;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetCollectionGroupUsers", "GetCollectionGroupUsers", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "GetCollectionGroupUsers", ex, MethodBase.GetCurrentMethod(), null);
            }
           
        }
        private string GetNombrePerson(Guid uidPerson)
        {
            try
            {
                string nombrePersona = "";
                var person =  _iunitOfWork.PersonPersonRepository.FindAllAsync(x => x.UID == uidPerson).Result.FirstOrDefault();
                if(person != null)
                {
                    nombrePersona = person.Nombre;
                }
                return nombrePersona;
            }
            catch (CError e)
            {
                throw _errorManager.AddError("GetNombrePerson", "GetNombrePerson", e, MethodBase.GetCurrentMethod(), null);
            }
            catch (System.Exception ex)
            {
                throw _errorManager.AddError("Error Generico", "GetNombrePerson", ex, MethodBase.GetCurrentMethod(), null);
            }
        }
        private string getCollectionSplitUser(List<GroupUsers> collection)
        {
            string retorno = "";
            if(collection != null)
            {
                var collectionOrden = collection.OrderBy(x => x.orden);
                foreach (var item in collectionOrden)
                    retorno += item.uidPerson.ToString() + ";";
            }
            
            return retorno;
        }
        private string getCollectionSplitPaymentUser(List<GroupUsers> collection)
        {
            string retorno = "";
            if (collection != null)
            {
                var collectionOrden = collection.OrderBy(x => x.orden);
                foreach (var item in collectionOrden)
                    retorno += item.unidades.ToString() + ";";
            }

            return retorno;
        }
        private List<int> getCollectionPaymentUser(string source)
        {
            List<int> lstretorno = new List<int>();
            if (!string.IsNullOrEmpty(source))
            {
                var arrarInt = source.Split(";");
                foreach (var item in arrarInt)
                {
                    if (!string.IsNullOrEmpty(item.ToString()))
                    {
                        lstretorno.Add(int.Parse(item));
                    }
                }
            }
            return lstretorno;
        }
        private void GetInstalaciones()
        {
            
        }

        #endregion

    }
}
