using Repository.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.interfaces
{
    public interface IStoreProcedureRepository
    {
        Task<List<UsuarioRespository_Dto>> XportsGetUserPerson(UserFilterRepository_Dto filter);
        Task<List<InstalacionRespositoryDto>> XportsGetInstalation(ReservaFilterRepositoryDto filter);
        Task<List<EventoRepositoryDto>> XportsGetReservasByUIDCompany(ReservaFilterRepositoryDto filter);
        Task<RetornoProcedureDto> XportsInstalacionesReservaInsert(ReservaRepositoryDto filter);

        Task<RetornoProcedureDto> XportsInstalacionesReservaUpdate(ReservaRepositoryDto filter);

        Task<List<CajaMovimientosRepositoryDto>> XportsGetCajaMovimientosByUIDCompanyFecha(Guid company);

        Task<RetornoProcedureDto> XportsRecibosInsert(ReciboRepositoryDto filter);

        Task<RetornoProcedureDto> XportsCajaMovimientoInsert(LineaMovimientoRepositoryDto filter);

        Task<List<RecibosByUidPersonRepositoryDto>> XportsGetRecibosByUIDPerson(RecibosByPersonFilterRepository filter);

    }
}
