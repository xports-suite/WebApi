using Api_xports.Features.Base.DTO;
using Api_xports.Features.Base.Enum;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Cuenta.DTO;
using Api_xports.Features.SendEmail.Services;
using Api_xports.Features.User.DTO;
using Api_xports.Features.User.DTO.Response;
using Api_xports.Log;
using Domain.Identity;
using Domain.xports.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Repository.DTO;
using Repository.interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Api_xports.Features.User.DTO.Request;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;

namespace Api_xports.Features.User.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class UserServices : IUserServices
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRoles> _roleManager;
        private readonly IUnitOfWork _iunitOfWork;
        private readonly ILog _log;
        private readonly IConfiguration _configuration;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IErrorManager _errorManager;
        private readonly IStoreProcedureRepository _storeProcedure;
        private readonly IEmailService _emailService;
        private readonly MapperUser _mapper;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="iunitOfWork"></param>
        /// <param name="log"></param>
        /// <param name="configuration"></param>
        /// <param name="signInManager"></param>
        /// <param name="roleManager"></param>
        /// <param name="errorManager"></param>
        /// <param name="storeProcedure"></param>
        /// <param name="emailService"></param>
        public UserServices(UserManager<ApplicationUser> userManager,
            IUnitOfWork iunitOfWork,
            ILog log,
            IConfiguration configuration,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<ApplicationRoles> roleManager,
            IErrorManager errorManager,
            IStoreProcedureRepository storeProcedure,
            IEmailService emailService)
        {
            _userManager = userManager;
            _iunitOfWork = iunitOfWork;
            _log = log;
            _configuration = configuration;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _errorManager = errorManager;
            _storeProcedure = storeProcedure;
            _emailService = emailService;
            _mapper = new MapperUser();
        }
        /// <summary>
        /// Creacion de usuario
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidationModel> AddUserApp(AddUserAppRequest request)
        {
            try
            {
                // return null;
                ApplicationUser appUser = new ApplicationUser()
                {
                    UserName = request.email,
                    Email = request.email
                };
                var existeUser = await ExisteUsuario(request.email, request.email);
                if (existeUser)
                {
                    request.ValidationResults.Add(new ValidationResult("Usuario existente", new[] { "Usuario Existente" }));
                    return request;
                }
                return await CrearUserApp(request);
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("AddUserApp", "UserService_AddUserApp", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error metodo AddUserApp", "UserService_AddUserApp", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
        }
        
        /// <summary>
        /// Modificacion de los datos de un usuario logado
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidationModel> SetUserApp(SetUserAppRequest request)
        {
            try {
                UserAppResponse userAppResponse = new UserAppResponse();
                var _aspUser = await _userManager.FindByIdAsync(request.uiPerson);
                if(_aspUser != null)
                {
                    _aspUser.UserName = request.email;
                    _aspUser.NormalizedEmail = request.email;
                    _aspUser.Email = request.email;
                    _aspUser.NormalizedEmail = request.email;
                    await _userManager.UpdateAsync(_aspUser);
                    var _securitUser = await _iunitOfWork.SecurityUserRepository.FindAsync(x => x.UID == Guid.Parse(_aspUser.Id));
                    if (_securitUser != null)
                    {
                        _securitUser.UID_PROFILE = Guid.Parse(request.idRool);
                        _securitUser.Username = request.email;
                        await _iunitOfWork.SecurityUserRepository.UpdateAsync(_securitUser);
                    }
                    return new UserAppResponse()
                    {
                        email = _aspUser.Email,
                        idRool = _securitUser.UID_PROFILE.Value,
                        uicompany = _securitUser.UID_COMPANY,
                        uiPerson = _securitUser.UID_PERSON
                    };
                }
                return userAppResponse;


            }
            catch(CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("SetUserApp", "UserService_SetUserApp", e, MethodBase.GetCurrentMethod(), jsonModel);

            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error metodo SetUserApp", "UserService_SetUserApp", ex, MethodBase.GetCurrentMethod(), jsonModel);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidationModel> AddUser(AddUserRequest request)
        {
            try {
                UserResponse response = new UserResponse();
                var userInsert = await InsertUsuario(request);
                return _mapper.Parse(userInsert);
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("AddUser", "UserService_AddUser", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error metodo AddUser", "UserService_AddUser", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }



        }
        /// <summary>
        /// Modifica un usuario de la aplicacion.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidationModel> SetUser(SetUserRequest request)
        {
            try {
                UserResponse response = new UserResponse();
                return await SetUsuario(request);
            }
            catch(CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("AddUser", "UserService_SetUser", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "UserService_SetUser", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uidCompany"></param>
        /// <param name="idMenu"></param>
        /// <returns></returns>
        public async Task<ValidationModel> GetUsers(Guid uidCompany , string idMenu)
        {
            UserCollectionReponse response = new UserCollectionReponse();
            try {
                response.Users = new List<UserResponse>();
                UserFilterRepository_Dto filtroMenu = new UserFilterRepository_Dto();
                filtroMenu.UID_Company = uidCompany;
                filtroMenu.IdMenu = string.IsNullOrEmpty(idMenu) ? 0 : int.Parse(idMenu);

                var colectionUser = await _storeProcedure.XportsGetUserPerson(new UserFilterRepository_Dto() { 
                    UID_Company = uidCompany,
                    IdMenu = string.IsNullOrEmpty(idMenu) ? 0 : int.Parse(idMenu)
                });
                var listaux = colectionUser.ToList();
                foreach(var userRep in listaux)
                    response.Users.Add(_mapper.Parse(userRep));
                return response;
            }
            catch(CError e)
            {
                var sparameters = "uidCompany : " + uidCompany.ToString() + " idMenu : " + idMenu == null ? "" : idMenu.ToString(); 
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("GetUsers", "UserService_GetUsers", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch(System.Exception ex)
            {
                var sparameters = "uidCompany : " + uidCompany.ToString() + " idMenu : " + idMenu == null ? "" : idMenu.ToString();
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("Error Generico", "UserService_GetUsers", ex, MethodBase.GetCurrentMethod(), jsonModel);

            }
        }
        /// <summary>
        /// Devuelve los registros de un usuario logado en la plataforma
        /// </summary>
        /// <param name="uiPerson"></param>
        /// <returns></returns>
        public async Task<ValidationModel> GetUserApp(Guid uiPerson)
        {
            try {
                UserAppResponse _response = new UserAppResponse();
                var securityUser = _iunitOfWork.SecurityUserRepository.FindAllAsync(x => x.UID_PERSON == uiPerson).Result.FirstOrDefault();
                var person = await _iunitOfWork.PersonPersonRepository.FindAsync(x => x.UID == uiPerson);
                if(securityUser != null)
                {
                    _response.email = securityUser.Username;
                    _response.idRool = securityUser.UID_PROFILE != null ? securityUser.UID_PROFILE.Value : Guid.Empty;
                    _response.uiPerson = securityUser.UID;
                    _response.uicompany = securityUser.UID_COMPANY;
                    _response.NombreCompleto = person.Nombre + " " + person.Apellidos;
                    _response.Foto = string.IsNullOrEmpty(person.Foto) ? "profile.jpg" : person.Foto + ".jpg";
                    //_response.Foto = "assets/images/avatars/arena_simple.jpg";
                }
                return await Task.Run(() => _response);
                // return _response;
            }
            catch (CError e)
            {
                var sparameters = "uiPerson : " + uiPerson.ToString();
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("GetUserApp", "UserService_GetUserApp", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var sparameters = "uiPerson : " + uiPerson.ToString();
                var jsonModel = JsonConvert.SerializeObject(sparameters);
                throw _errorManager.AddError("Error Generico", "UserService_GetUserApp", ex, MethodBase.GetCurrentMethod(), jsonModel);

            }
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public async Task<ValidationModel> LoginUser(string login)
        {
            try {
                var _userInfo = await GetInfoUserAsync(login);
                if (_userInfo.LockOutEnabled)
                {
                    var _clains = CrearClaisUsuario(_userInfo);
                    var _token = GenerateToken(_clains);
                    var _RefresToken = GenerateRefreshToken();

                    Token token = new Token()
                    {
                        TokenBeear = _token.Token,
                        RefresToken = _RefresToken,
                        
                    };
                    await SaveTokenRefres(token, _userInfo.Id);

                    // Recuperamos el UICompany , del usuario logado.
                    Security_User _securitUser = new Security_User();
                    if (!string.IsNullOrEmpty(_userInfo.Id))
                    {
                        Guid _uiUser = Guid.Parse(_userInfo.Id);
                        _securitUser = _iunitOfWork.SecurityUserRepository.FindAsync(x => x.UID == _uiUser).Result;
                    }

                    return new TokenResponse()
                    {
                        RefresToken = _RefresToken,
                        TokenBeear = _token.Token,
                        UICompany = _securitUser != null ? _securitUser.UID_COMPANY.ToString() : "",
                        UIPerson = _securitUser != null ? _securitUser.UID_PERSON.ToString() : "",
                    };
                }
                else
                {
                    var jsonModel = JsonConvert.SerializeObject(login);
                    throw _errorManager.AddError("Usuario bloquedo", "UserService", MethodBase.GetCurrentMethod(), jsonModel);
                }
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(login);
                throw _errorManager.AddError("Error generico login", "LoginUser", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<ValidationModel> GetMenuRol(string token)
        {
            try {

                FuseNavigationResponse _response = new FuseNavigationResponse();
                var user = _iunitOfWork.UserTokenRepository.FindAllAsync(x => x.Token == token).Result.FirstOrDefault();
                if (user == null)
                {
                    _response.ValidationResults.Add(new ValidationResult("No existe Rol / Usuario", new[] { "GetMenuRol -> no existe Rol / Usuario" }));
                    return _response;

                }

                //Recuperamos el 
                var _userRolNet = _iunitOfWork.NetUserRolesRepository.FindAllAsync(x => x.UserId == user.User_Id).Result.FirstOrDefault();
                _response = await LoadMenuFuseNavigationAsync(new Guid(_userRolNet.RoleId));
                return _response;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(token);
                throw _errorManager.AddError("Error Get Rol", "GetMenuRol", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(token);
                throw _errorManager.AddError("Error Get Rol", "GetMenuRol", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
        }

        

        #region function private Login
        private async Task<Boolean> ExisteUsuario(string username, string email)
        {
            try
            {
                var _userLogin = await _userManager.FindByNameAsync(username);
                var _userEmail = await _userManager.FindByEmailAsync(email);

                if (_userLogin == null && _userEmail == null)
                    return false;
                else
                    return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        private async Task<ValidationModel> CrearUserApp(AddUserAppRequest dto)
        {
            try {
                AddUserResponse _response = new AddUserResponse();
                ApplicationUser appUser = new ApplicationUser()
                {
                    UserName = dto.email,
                    Email = dto.email
                };
                // Genera passowrd aleatoria
                string pws = GetPassword();
                var _result = await _userManager.CreateAsync(appUser, pws);


                //_responseBase.bOK = _result.Succeeded;
                if (_result.Succeeded)
                {
                    var idUserApp = _userManager.FindByNameAsync(dto.email).Result.Id;
                    //Asociamos el rool al usuario
                    var bRolUser = await AssignUserRole(appUser, dto.idRool);
                    if (bRolUser)
                    {

                        //Insertamos en la tabla SecurityUser
                        await _iunitOfWork.SecurityUserRepository.InsertEntity(new Security_User()
                        {
                            Activo = true,
                            Fecha_Alta = DateTime.Now,
                            Username = appUser.Email,
                            UID_COMPANY = Guid.Parse(dto.uicompany),
                            UID_PERSON = Guid.Parse(dto.uiPerson),
                            UID_PROFILE = Guid.Parse(dto.idRool),
                            UID = Guid.Parse(idUserApp)

                        });
                        await _iunitOfWork.SecurityUserRepository.SaverChangeAsyc();
                        // Enviar email.
                        string msj = "El usuario con username :" + dto.email + " y con password: " + pws;
                        await _emailService.SendEmail("inovod@smilycode.es", msj, "Creacion usuario app");
                        _response = new AddUserResponse()
                        {
                            IdUser = appUser.Id,
                            UserName = appUser.UserName,
                            Rol = dto.idRool
                        };
                    }
                }
                else
                {
                    foreach (var error in _result.Errors)
                    {
                        var jsonModel = JsonConvert.SerializeObject(dto);
                        if (error.Code == "PasswordRequiresNonAlphanumeric")
                            throw _errorManager.AddError("Las contraseñas deben tener al menos un carácter no alfanumérico.", "CrearUserApp", MethodBase.GetCurrentMethod(), jsonModel);
                        if (error.Code == "PasswordTooShort")
                            throw _errorManager.AddError("Las contraseñas deben tener al menos 6 caracteres.", "CrearUserApp", MethodBase.GetCurrentMethod(), jsonModel);
                        if (error.Code == "PasswordRequiresDigit")
                            throw _errorManager.AddError("Las contraseñas deben tener al menos un dígito ('0' - '9')", "CrearUserApp", MethodBase.GetCurrentMethod(), jsonModel);
                    }
                }
                return _response;
            }
            catch(CError ce)
            {
                var jsonModel = JsonConvert.SerializeObject(dto);
                throw _errorManager.AddError("Error CrearUserApp", "CrearUserApp", ce, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch(System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(dto);
                throw _errorManager.AddError("Error CrearUserApp", "CrearUserApp", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
          
        }
        private async Task<bool> AssignUserRole(ApplicationUser AppUser, string idrol)
        {
            ApplicationRoles _approol = await _roleManager.FindByIdAsync(idrol);
            var _result = await _userManager.AddToRoleAsync(AppUser, _approol.NormalizedName);
            if (_result.Succeeded) return true; else return false;
        }
        private async Task<string> DeleteUser(string username)
        {
            ApplicationUser _appUser = await _userManager.FindByNameAsync(username);
            if (_appUser != null)
            {
                _log.Information("Elimina usuario " + username);
                //Eliminamos los registros de AspNetUsers
                try { await _userManager.DeleteAsync(_appUser); }
                catch (System.Exception ex)
                {
                    var contenido = ex.Message;
                }

            }
            return "";
        }

        private Token_Dto GenerateToken(IEnumerable<Claim> claims)
        {
            Token_Dto token = new Token_Dto();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var jwt = new JwtSecurityToken(issuer: "Blinkingcaret",
                audience: "Everyone",
                claims: claims, //the user's claims, for example new Claim[] { new Claim(ClaimTypes.Name, "The username"), //... 
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: creds
            );
            return new Token_Dto()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(jwt),
                ValidateToken = jwt.ValidFrom.ToString()
            };

        }

        private async Task<UserInfo_Dto> GetInfoUserAsync(string login)
        {
            UserInfo_Dto _userInfor;
            ApplicationUser _userApp = await _userManager.FindByNameAsync(login);
            if (_userApp != null)
            {
                _userInfor = new UserInfo_Dto(_userApp.Id.ToString(), _userApp.LockoutEnabled);
                return _userInfor;
            }
            else { return null; }
        }
        private IEnumerable<Claim> CrearClaisUsuario(UserInfo_Dto userInfo)
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            return claims;
        }

        private string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        private async Task<string> SaveTokenRefres(Token token, string idUser)
        {
            try
            {
                var userToken = _iunitOfWork.UserTokenRepository.FindAllAsync(x => x.User_Id == idUser).Result.FirstOrDefault();
                if (userToken != null)
                {
                    userToken.RefresToken = token.RefresToken;
                    userToken.Token = token.TokenBeear;
                    await _iunitOfWork.UserTokenRepository.UpdateAsync(userToken);
                }
                else
                {

                    await _iunitOfWork.UserTokenRepository.CreateAsync(new UserToken()
                    {
                        Id = Guid.NewGuid(),
                        User_Id = idUser,
                        Token = token.TokenBeear,
                        RefresToken = token.RefresToken
                    });
                    await _iunitOfWork.UserTokenRepository.SaverChangeAsyc();
                }
            }
            catch (System.Exception e)
            {
                var excpetion = e;
            }
            return "";
        }

        #endregion

        #region function private Menu
        private async Task<FuseNavigationResponse> LoadMenuFuseNavigationAsync(Guid rol)
        {



            //List<FuseNavigationResponse> menuColection = new List<FuseNavigationResponse>();
            FuseNavigationResponse menu = new FuseNavigationResponse();
            menu.Navigation = new List<FNavigationN1Response>();


            var collectionMenu = await _iunitOfWork.MasterJerarquiaMenusRepository.GetAllAsync();
            var rolmenu = collectionMenu.Where(x => x.UID_PERFIL == rol);
            //Recuperamos los id padres 
            var itemspadres = rolmenu.Where(x => x.Nivel == 1 && x.UID_Padre is null);
            foreach (var i1 in itemspadres)
            {
                FNavigationN1Response itemPrimerNivel = new FNavigationN1Response();
                itemPrimerNivel.id = i1.UID_FUNCTION.ToString();
                itemPrimerNivel.title = i1.Menu;
                itemPrimerNivel.translate = i1.Menu;
                itemPrimerNivel.type = "group";
                itemPrimerNivel.icon = string.IsNullOrEmpty(i1.Icono) ? "" : i1.Icono;
                //Cargamos los hijos de segundo nivel
                var collectionSegundNivel = rolmenu.Where(x => x.UID_Padre == i1.UID_FUNCTION && x.Nivel == 2);
                itemPrimerNivel.children = new List<FNavigationN2Response>();
                foreach (var i2 in collectionSegundNivel)
                {
                    FNavigationN2Response itemSegundoNivel = new FNavigationN2Response();
                    itemSegundoNivel.id = i2.UID_FUNCTION.ToString();
                    itemSegundoNivel.title = i2.Menu;
                    itemSegundoNivel.translate = i2.Menu;
                    itemSegundoNivel.icon = string.IsNullOrEmpty(i2.Icono) ? "" : i2.Icono;
                    if (!string.IsNullOrEmpty(i2.Url))
                    {
                        itemSegundoNivel.type = "item";
                        itemSegundoNivel.url = i2.Url;
                    }
                    else
                    {
                        itemSegundoNivel.type = "collapsable";
                    }


                    //Cargamos el tercer nivel
                    var collectionTercerNivel = rolmenu.Where(x => x.UID_Padre == i2.UID_FUNCTION && x.Nivel == 3);
                    itemSegundoNivel.children = new List<FNavigationN3Response>();
                    foreach (var i3 in collectionTercerNivel)
                    {
                        FNavigationN3Response item3Nivel = new FNavigationN3Response();
                        item3Nivel.id = i3.UID_FUNCTION.ToString();
                        item3Nivel.title = i3.Menu;
                        item3Nivel.type = "item";
                        item3Nivel.url = i3.Url;
                        itemSegundoNivel.children.Add(item3Nivel);
                    }
                    itemPrimerNivel.children.Add(itemSegundoNivel);
                }
                menu.Navigation.Add(itemPrimerNivel);
            }

            return menu;
        }
        #endregion

        #region funcion private user 
        private async Task<Person_Person> InsertUsuario(AddUserRequest usuario)
        {
            try {
                string codeUser = GetCodeUser(Guid.Parse(usuario.uiCompany));
                Person_Person _entity = new Person_Person();
                _entity.UID_COMPANY = Guid.Parse(usuario.uiCompany);
                _entity.Code = codeUser;
                _entity.Activo = true;
                _entity.Fecha_Alta = DateTime.Now;
                _entity.UID_TIPOPERSONAL = Guid.Parse(usuario.idTypePersona);
                _entity.Nombre = usuario.Nombre;
                _entity.Apellidos = usuario.Apellidos;
                _entity.Telefono = usuario.Movil;
                _entity.Telefono2 = usuario.TlfFijo;
                _entity.Email = usuario.Email;
                _entity.Direccion = usuario.Direccion;
                _entity.Ciudad = usuario.Ciudad;
                _entity.Provincia = usuario.Provincia;
                _entity.CodigoPostal = usuario.CodigPostal;
                _entity.Foto = usuario.Foto;
                _entity.Sexo = usuario.Sexo;
                _entity.DNI = usuario.DNI;
                _entity.FechaNacimiento = usuario.FNacimiento;
                _entity.Nacionalidad = usuario.Nacionalidad;
                _entity.Talla = usuario.Talla;
                _entity.Num_Cuenta = usuario.NumeroCuenta;
                _entity.DomiciliarRecibos = usuario.DomiciliarRecibos;
                _entity.Observaciones = usuario.Observaciones;
                await _iunitOfWork.PersonPersonRepository.InsertEntity(_entity);
                await _iunitOfWork.PersonPersonRepository.SaverChangeAsyc();
                return _entity;
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(usuario);
                throw _errorManager.AddError("Error Crear Usuario", "CrearUsuario", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }

        }

        private async Task<UserResponse> SetUsuario(SetUserRequest request)
        {
            UserResponse _response = new UserResponse();

            try {
                //Recuperamos el usuario de la tabla
                Person_Person entity = GetPerson(Guid.Parse(request.id));
                if (entity == null)
                {
                    _response.ValidationResults.Add(new ValidationResult("No existe persona", new[] { "No existe persona" }));
                    return _response;
                }
                //Modificamos el person
                var entityUpdate = await UpdatePersonDb(entity, request);
                return _mapper.Parse(entityUpdate);
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "SetUsuario", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Set Usuario", "SetUsuario", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
        }
        private async Task<bool> AddUserAppAsync(SetUserRequest request)
        {
            try
            {
                AddUserResponse _response = new AddUserResponse();
                ApplicationUser appUser = new ApplicationUser()
                {
                    UserName = request.email,
                    Email = request.email
                };
                var result =  await _userManager.CreateAsync(appUser, GeneraPws(request.email));
                if (result.Succeeded)
                {
                    //var bRolUser = await AssignUserRole(appUser, request.ID_Rol);
                    return true;
                }
                return false;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "AddUserApp", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "AddUserApp", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
        }
        private string GeneraPws(string value)
        {
           return value.Substring(0, value.IndexOf('@'));
        }
        private Person_Person GetPerson(Guid idperson)
        {
            return _iunitOfWork.PersonPersonRepository.FindAllAsync(x => x.UID == idperson).Result.FirstOrDefault();
            
        }
        private string GetCodeUser(Guid companie)
        {
           return  _iunitOfWork.PersonPersonRepository.FindAllAsync(x => x.UID_COMPANY == companie).Result.Max(x => x.Code);
        }
        private async Task<Boolean> ExistsAspNetUser(string username, string email)
        {
            try
            {
                var _userLogin = await _userManager.FindByNameAsync(username);
                var _userEmail = await _userManager.FindByEmailAsync(email);

                if (_userLogin == null && _userEmail == null)
                    return false;
                else
                    return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }


        private async Task<Person_Person> UpdatePersonDb(Person_Person entity , SetUserRequest request)
        {
            try
            {
                entity.UID_TIPOPERSONAL = Guid.Parse(request.idTypePersona);
                entity.Nombre = request.nombre;
                entity.Apellidos = request.apellidos;
                entity.Telefono = request.movil;
                entity.Telefono2 = request.fijo;
                entity.Email = request.email;
                entity.Direccion = request.direccion;
                entity.Ciudad = request.ciudad;
                entity.Provincia = request.provincia;
                entity.CodigoPostal = request.codigoPostal;
                entity.Foto = request.foto;
                entity.Sexo = request.sexo;
                entity.DNI = request.dni;
                entity.FechaNacimiento = request.fechaNacimiento;
                entity.Nacionalidad = request.nacionalidad;
                entity.Talla = request.talla;
                entity.Num_Cuenta = request.numCuenta;
                entity.DomiciliarRecibos = request.domiciliarRecibos;
                entity.Observaciones = request.observaciones;
                await _iunitOfWork.PersonPersonRepository.UpdateAsync(entity);
                return entity;
            }
            catch (CError e)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "UpdatePersonDb", e, MethodBase.GetCurrentMethod(), jsonModel);
            }
            catch (System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManager.AddError("Error Generico", "UpdatePersonDb", ex, MethodBase.GetCurrentMethod(), jsonModel);
            }
           
        }

        private bool ValidateRolUser(int idrol)
        {

            if ((int)RoleEnum.Administrador == idrol)
                return true;
            if ((int)RoleEnum.Administrador == idrol)
                return true;
            if ((int)RoleEnum.GestorClub == idrol)
                return true;
            if ((int)RoleEnum.Recepcionista == idrol)
                return true;
            if ((int)RoleEnum.UsuarioRegistrado == idrol)
                return true;
            if ((int)RoleEnum.Invitado == idrol)
                return true;


            return false;
        }
        private string GetPassword()
        {
            string p1 = RandomPasswor("abcdefghijklmnopqrstuvwxyz", 3);
            string p2 = RandomPasswor("%$#@", 1);
            string p3 = RandomPasswor("1234567890", 1);
            string p4 = RandomPasswor("%$#@", 1);
            string p5 = RandomPasswor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 3);
            string p6 = RandomPasswor("%$#@", 1);
            return p1 + p2 + p3 + p4 + p5 + p6;
        }
        private string RandomPasswor(string cadena , int lgParteCadena)
        {
            Random rdn = new Random();
            //string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$#@";
            int longitud = cadena.Length;
            char letra;
            int longitudContrasenia = lgParteCadena;
            string contraseniaAleatoria = string.Empty;
            for (int i = 0; i < longitudContrasenia; i++)
            {
                letra = cadena[rdn.Next(longitud)];
                contraseniaAleatoria += letra.ToString();
            }
            return contraseniaAleatoria;
        }

     
        #endregion


    }
    /// <summary>
    /// Mapeo de la clase
    /// </summary>
    public class MapperUser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public UserResponse Parse(UsuarioRespository_Dto dto)
        {
            UserResponse response = new UserResponse();
            response.Id = dto.UID_Person.ToString();
            response.Foto = "";
            response.UiCompany = dto.UID_Company.ToString();
            response.Nombre = dto.Nombre;
            response.Apellidos = dto.Apellidos;
            response.NombreCompleto = dto.NombreCompleto;
            response.Email = dto.email;
            response.OpcionMenu = dto.Opcion_Menu.ToString();
            response.IdTypePerson = dto.UID_TipoPersonal;
            response.TlfMovil = dto.Telefono;
            response.TflFijo = dto.Telefono2;
            response.Direccion = dto.Direccion;
            response.Ciudad = dto.Ciudad;
            response.Provincia = dto.Provincia;
            response.CodigoPostal = dto.CodigoPostal;
            response.Sexo = dto.Sexo;
            response.DNI = dto.DNI;
            response.FNacimiento = dto.FechaNacimiento;
            response.Talla = dto.Talla;
            response.NumeroCuenta = dto.Num_Cuenta;
            response.DomiciliarRecibos = dto.DomiciliarRecibos;
            return response;
        }
        ///
        public UserResponse Parse(Person_Person dto)
        {
            UserResponse response = new UserResponse();
            response.Id = dto.UID.ToString();
            response.Foto = !string.IsNullOrEmpty(dto.Foto) ? dto.Foto : "";
            response.UiCompany = dto.UID_COMPANY.ToString();
            response.Nombre = dto.Nombre;
            response.Apellidos = dto.Apellidos;
            response.NombreCompleto = "";
            response.Email = !string.IsNullOrEmpty(dto.Email) ? dto.Email : "";
            response.IdTypePerson = dto.UID_TIPOPERSONAL == null ? Guid.Empty : dto.UID_TIPOPERSONAL;
            response.TlfMovil = dto.Telefono;
            response.TflFijo = dto.Telefono2;
            response.Direccion = dto.Direccion;
            response.Ciudad = dto.Ciudad;
            response.Provincia = dto.Provincia;
            response.CodigoPostal = dto.CodigoPostal;
            response.Sexo = dto.Sexo;
            response.DNI = dto.DNI;
            response.FNacimiento = dto.FechaNacimiento;
            response.Talla = dto.Talla;
            response.NumeroCuenta = dto.Num_Cuenta;
            response.DomiciliarRecibos = dto.DomiciliarRecibos.HasValue;
            return response;
        }
    }
}
