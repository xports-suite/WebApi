using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Domain.xports.Data.Models;
using Repository.DTO;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Repository
{
    public class StoreProcedureRepository : IStoreProcedureRepository
    {
        protected xports_devContext _xportsContext;

        public StoreProcedureRepository(xports_devContext ctx) => _xportsContext = ctx;
        
        public async Task<List<UsuarioRespository_Dto>> XportsGetUserPerson(UserFilterRepository_Dto filter)
        {
            List<UsuarioRespository_Dto> response = new List<UsuarioRespository_Dto>();
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_GetUserPerson";
            cmd.Parameters.Add(new SqlParameter("@uid_company", SqlDbType.UniqueIdentifier) { Value = filter.UID_Company });
            if(filter.IdMenu > 0)
            {
                cmd.Parameters.Add(new SqlParameter("@opcion_menu", SqlDbType.Int) { Value = filter.IdMenu });
            }
            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try {
                using (var reader = await cmd.ExecuteReaderAsync())
                    response = MapperStoreProcedure.MapToList<UsuarioRespository_Dto>(reader);
            }
            catch(System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => response.ToList());
        }

        public async Task<List<InstalacionRespositoryDto>> XportsGetInstalation(ReservaFilterRepositoryDto filter)
        {
            List<InstalacionRespositoryDto> response = new List<InstalacionRespositoryDto>();
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_GetInstalacionesByUIDCompany";
            cmd.Parameters.Add(new SqlParameter("@UID_COMPANY", SqlDbType.UniqueIdentifier) { Value = filter.uid_company});
            cmd.Parameters.Add(new SqlParameter("@UID_DEPORTE", SqlDbType.UniqueIdentifier) { Value = filter.uid_deporte });
            cmd.Parameters.Add(new SqlParameter("@dt_fecha", SqlDbType.DateTime) { Value = filter.fecha });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    response = MapperStoreProcedure.MapToList<InstalacionRespositoryDto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => response.ToList());
        }

        public async Task<List<EventoRepositoryDto>> XportsGetReservasByUIDCompany(ReservaFilterRepositoryDto filter)
        {
            List<EventoRepositoryDto> response = new List<EventoRepositoryDto>();
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_GetReservasByUIDCompany";
            cmd.Parameters.Add(new SqlParameter("@UID_COMPANY", SqlDbType.UniqueIdentifier) { Value = filter.uid_company });
            cmd.Parameters.Add(new SqlParameter("@UID_DEPORTE", SqlDbType.UniqueIdentifier) { Value = filter.uid_deporte });
            cmd.Parameters.Add(new SqlParameter("@dt_fecha", SqlDbType.DateTime) { Value = filter.fecha });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    response = MapperStoreProcedure.MapToList<EventoRepositoryDto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => response.ToList());
        }

        public async Task<List<RecibosByUidPersonRepositoryDto>> XportsGetRecibosByUIDPerson(RecibosByPersonFilterRepository filter)
        {
            List<RecibosByUidPersonRepositoryDto> response = new List<RecibosByUidPersonRepositoryDto>();
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_GetRecibosByUIDPerson";
            cmd.Parameters.Add(new SqlParameter("@UID_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.uidReserva });
            cmd.Parameters.Add(new SqlParameter("@UID_Person", SqlDbType.UniqueIdentifier) { Value = filter.uidPersona });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    response = MapperStoreProcedure.MapToList<RecibosByUidPersonRepositoryDto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => response.ToList());
        }

        public async Task<List<CajaMovimientosRepositoryDto>> XportsGetCajaMovimientosByUIDCompanyFecha(Guid company)
        {
            List<CajaMovimientosRepositoryDto> response = new List<CajaMovimientosRepositoryDto>();
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_GetCajaMovimientosByUIDCompanyFecha";
            cmd.Parameters.Add(new SqlParameter("@UID_COMPANY", SqlDbType.UniqueIdentifier) { Value = company});
            cmd.Parameters.Add(new SqlParameter("@dt_fecha", SqlDbType.DateTime) { Value = DateTime.Now });

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                using (var reader = await cmd.ExecuteReaderAsync())
                    response = MapperStoreProcedure.MapToList<CajaMovimientosRepositoryDto>(reader);
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => response.ToList());
        }

        public async Task<RetornoProcedureDto> XportsInstalacionesReservaInsert(ReservaRepositoryDto filter)
        {
            RetornoProcedureDto retornoPro = new RetornoProcedureDto();
            int resultado = 0;
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_InstalacionesReserva_Insert";
            cmd.Parameters.Add(new SqlParameter("@UID_Instalacion", SqlDbType.UniqueIdentifier) { Value = filter.UID_Instalacion });
            cmd.Parameters.Add(new SqlParameter("@dt_inicio", SqlDbType.DateTime) { Value = filter.dt_inicio});
            cmd.Parameters.Add(new SqlParameter("@dt_fin", SqlDbType.DateTime) { Value = filter.dt_fin });
            cmd.Parameters.Add(new SqlParameter("@UID_Person_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.UID_Person_Reserva });
            cmd.Parameters.Add(new SqlParameter("@UID_Tipo_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.UID_TipoReserva });
            cmd.Parameters.Add(new SqlParameter("@vc_UID_Todos_Usuarios", SqlDbType.NVarChar) { Value = filter.uidGropusUser });
            cmd.Parameters.Add(new SqlParameter("@vc_Num_partes", SqlDbType.NVarChar) { Value = filter.idPaymentPartsUsers });
            cmd.Parameters.Add(new SqlParameter("@bt_Pagado", SqlDbType.Bit) { Value = 0 });
            cmd.Parameters.Add(new SqlParameter("@bt_Activo", SqlDbType.Bit) { Value = 1 });
            cmd.Parameters.Add(new SqlParameter("@vc_Observaciones", SqlDbType.VarChar) { Value = string.Empty });
            cmd.Parameters.Add(new SqlParameter("@vc_accion", SqlDbType.Char) { Value = 'I' });

            SqlParameter pvUID_Reserva = new SqlParameter();
            pvUID_Reserva.ParameterName = "@UID_Reserva";
            pvUID_Reserva.DbType = DbType.String;
            pvUID_Reserva.Direction = ParameterDirection.Output;
            pvUID_Reserva.Size = 255;
            cmd.Parameters.Add(pvUID_Reserva);

            SqlParameter pvvc_mensaje_error = new SqlParameter();
            pvvc_mensaje_error.ParameterName = "@vc_mensaje_error";
            pvvc_mensaje_error.DbType = DbType.String;
            pvvc_mensaje_error.Direction = ParameterDirection.Output;
            pvvc_mensaje_error.Size = 255;
            cmd.Parameters.Add(pvvc_mensaje_error);


            SqlParameter pvcod_error = new SqlParameter();
            pvcod_error.ParameterName = "@cod_error";
            pvcod_error.DbType = DbType.String;
            pvcod_error.Direction = ParameterDirection.Output;
            pvcod_error.Size = 255;
            cmd.Parameters.Add(pvcod_error);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
                retornoPro.berror = false;
                retornoPro.msjError = string.Empty;
                if (!string.IsNullOrEmpty(pvcod_error.Value.ToString()))
                {
                    if (int.Parse(pvcod_error.Value.ToString()) < 0)
                    {
                        retornoPro.berror = true;
                        retornoPro.msjError = pvvc_mensaje_error.Value.ToString();
                    }
                }
                else
                {
                    retornoPro.uidRetorno = pvUID_Reserva.Value.ToString();
                }
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retornoPro);
        }

        public async Task<RetornoProcedureDto> XportsInstalacionesReservaUpdate(ReservaRepositoryDto filter)
        {
            RetornoProcedureDto retornoPro = new RetornoProcedureDto();
            Guid _tipoReserva = new Guid("693229D0-521A-4FFE-9777-0824AC85F8BB");
            int resultado = 0;
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_InstalacionesReserva_Update";
            cmd.Parameters.Add(new SqlParameter("@UID_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.UID_Reserva });
            cmd.Parameters.Add(new SqlParameter("@UID_Instalacion", SqlDbType.UniqueIdentifier) { Value = filter.UID_Instalacion });
            cmd.Parameters.Add(new SqlParameter("@dt_inicio", SqlDbType.DateTime) { Value = filter.dt_inicio });
            cmd.Parameters.Add(new SqlParameter("@dt_fin", SqlDbType.DateTime) { Value = filter.dt_fin });
            cmd.Parameters.Add(new SqlParameter("@UID_Person_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.UID_Person_Reserva });
            cmd.Parameters.Add(new SqlParameter("@vc_UID_Todos_Usuarios", SqlDbType.NVarChar) { Value = filter.uidGropusUser});
            cmd.Parameters.Add(new SqlParameter("@vc_Num_partes", SqlDbType.NVarChar) { Value = filter.idPaymentPartsUsers });
            cmd.Parameters.Add(new SqlParameter("@bt_Activo", SqlDbType.Bit) { Value = 1 });
            cmd.Parameters.Add(new SqlParameter("@vc_Observaciones", SqlDbType.VarChar) { Value = string.Empty });
            cmd.Parameters.Add(new SqlParameter("@vc_accion", SqlDbType.Char) { Value = 'U' });


            SqlParameter pvvc_mensaje_error = new SqlParameter();
            pvvc_mensaje_error.ParameterName = "@vc_mensaje_error";
            pvvc_mensaje_error.DbType = DbType.String;
            pvvc_mensaje_error.Direction = ParameterDirection.Output;
            pvvc_mensaje_error.Size = 255;
            cmd.Parameters.Add(pvvc_mensaje_error);


            SqlParameter pvcod_error = new SqlParameter();
            pvcod_error.ParameterName = "@cod_error";
            pvcod_error.DbType = DbType.String;
            pvcod_error.Direction = ParameterDirection.Output;
            pvcod_error.Size = 255;
            cmd.Parameters.Add(pvcod_error);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();
                retornoPro.berror = false;
                retornoPro.msjError = string.Empty;

                if (!string.IsNullOrEmpty(pvcod_error.Value.ToString()))
                {
                    if (int.Parse(pvcod_error.Value.ToString()) < 0)
                    {
                        retornoPro.berror = true;
                        retornoPro.msjError = pvvc_mensaje_error.Value.ToString();
                    }
                }
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retornoPro);
        }

        public async Task<RetornoProcedureDto> XportsRecibosInsert(ReciboRepositoryDto filter)
        {
            RetornoProcedureDto retornoPro = new RetornoProcedureDto();
            int resultado = 0;
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_Recibos_Insert";
            cmd.Parameters.Add(new SqlParameter("@uid_person", SqlDbType.UniqueIdentifier) { Value = filter.uidPerson });
            cmd.Parameters.Add(new SqlParameter("@uid_Reserva", SqlDbType.UniqueIdentifier) { Value = filter.uiReserva });
            
            SqlParameter pvvc_mensaje_error = new SqlParameter();
            pvvc_mensaje_error.ParameterName = "@vc_mensaje_error";
            pvvc_mensaje_error.DbType = DbType.String;
            pvvc_mensaje_error.Direction = ParameterDirection.Output;
            pvvc_mensaje_error.Size = 255;
            cmd.Parameters.Add(pvvc_mensaje_error);


            SqlParameter pvcod_error = new SqlParameter();
            pvcod_error.ParameterName = "@cod_error";
            pvcod_error.DbType = DbType.String;
            pvcod_error.Direction = ParameterDirection.Output;
            pvcod_error.Size = 255;
            cmd.Parameters.Add(pvcod_error);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {
                resultado = await cmd.ExecuteNonQueryAsync();

                if (resultado < 0)
                {
                    retornoPro.berror = true;
                    retornoPro.msjError = pvvc_mensaje_error.Value.ToString();
                }
                else
                {
                    retornoPro.berror = false;
                    retornoPro.msjError = string.Empty;
                }
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retornoPro);
        }

        public async Task<RetornoProcedureDto> XportsCajaMovimientoInsert(LineaMovimientoRepositoryDto filter)
        {
            RetornoProcedureDto retornoPro = new RetornoProcedureDto();
            int resultado = 0;
            DbCommand cmd = _xportsContext.Database.GetDbConnection().CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "Xports_Caja_Movimiento_Insert";
            cmd.Parameters.Add(new SqlParameter("@uid_company", SqlDbType.UniqueIdentifier) { Value = filter.uidcompany });
            cmd.Parameters.Add(new SqlParameter("@uid_TipoMovimiento", SqlDbType.UniqueIdentifier) { Value = filter.uidTipoMovimiento });
            cmd.Parameters.Add(new SqlParameter("@uid_FormaPago", SqlDbType.UniqueIdentifier) { Value = filter.uidFormaPago });
            cmd.Parameters.Add(new SqlParameter("@uid_User", SqlDbType.UniqueIdentifier) { Value = filter.uidUser });
            cmd.Parameters.Add(new SqlParameter("@vc_recibos", SqlDbType.NVarChar) { Value = filter.uidRecibos });

            SqlParameter pvvc_mensaje_error = new SqlParameter();
            pvvc_mensaje_error.ParameterName = "@vc_mensaje_error";
            pvvc_mensaje_error.DbType = DbType.String;
            pvvc_mensaje_error.Direction = ParameterDirection.Output;
            pvvc_mensaje_error.Size = 255;
            cmd.Parameters.Add(pvvc_mensaje_error);


            SqlParameter pvcod_error = new SqlParameter();
            pvcod_error.ParameterName = "@cod_error";
            pvcod_error.DbType = DbType.String;
            pvcod_error.Direction = ParameterDirection.Output;
            pvcod_error.Size = 255;
            cmd.Parameters.Add(pvcod_error);

            if (cmd.Connection.State == System.Data.ConnectionState.Closed)
            {
                await cmd.Connection.OpenAsync();
            }
            try
            {

                resultado = await cmd.ExecuteNonQueryAsync();
                retornoPro.berror = false;
                retornoPro.msjError = string.Empty;
                if (!string.IsNullOrEmpty(pvcod_error.Value.ToString()))
                {
                    if (int.Parse(pvcod_error.Value.ToString()) < 0)
                    {
                        retornoPro.berror = true;
                        retornoPro.msjError = pvvc_mensaje_error.Value.ToString();
                    }
                }


                /*resultado = await cmd.ExecuteNonQueryAsync();

                if (resultado < 0)
                {
                    retornoPro.berror = true;
                    retornoPro.msjError = pvvc_mensaje_error.Value.ToString();
                }
                else
                {
                    retornoPro.berror = false;
                    retornoPro.msjError = string.Empty;
                }*/
            }
            catch (System.Exception e)
            {
                throw (e);
            }
            finally
            {
                cmd.Connection.Close();
            }
            return await Task.Run(() => retornoPro);
        }

    }

    public static class MapperStoreProcedure
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dr"></param>
        /// <returns></returns>
        public static List<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();
            var colMapping = dr.GetColumnSchema()
              .Where(x => props.Any(y => y.Name.ToLower() == x.ColumnName.ToLower()))
              .ToDictionary(key => key.ColumnName.ToLower());

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        var val =
                          dr.GetValue(colMapping[prop.Name.ToLower()].ColumnOrdinal.Value);
                        prop.SetValue(obj, val == DBNull.Value ? null : val);
                    }
                    objList.Add(obj);
                }
            }
            return objList;
        }

    }
}
