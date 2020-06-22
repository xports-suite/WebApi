using Api_xports.Features.Base.Validation;
using Api_xports.Features.User.DTO.Request;
using System;
using System.Threading.Tasks;

namespace Api_xports.Features.User.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUserServices
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ValidationModel> AddUserApp(AddUserAppRequest request);
        ///
        Task<ValidationModel> SetUserApp(SetUserAppRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>

        Task<ValidationModel> AddUser(AddUserRequest request);

        /// <summary>
        /// Modificamos el usuario de la app
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<ValidationModel> SetUser(SetUserRequest request);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidCompany"></param>
        /// <param name="idMenu"></param>
        /// <returns></returns>
        Task<ValidationModel> GetUsers(Guid uidCompany, string idMenu);

        /// <summary>
        /// Devuelve los registros de un usuario logado
        /// </summary>
        /// <param name="uIdPerson"></param>
        /// <returns></returns>
        Task<ValidationModel> GetUserApp(Guid uIdPerson);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        Task<ValidationModel> LoginUser(string login);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        Task<ValidationModel> GetMenuRol(string token);



     }
}
