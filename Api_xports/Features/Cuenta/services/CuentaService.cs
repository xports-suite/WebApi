using Api_xports.Features.Base.Validation;
using Api_xports.Features.Cuenta.DTO;
using Api_xports.Features.User.DTO;
using Api_xports.Features.User.DTO.Response;
using Api_xports.Features.User.Services;
using Domain.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Internal.Account;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace Api_xports.Features.Cuenta.services
{
    /// <summary>
    /// 
    /// </summary>
    public class CuentaService :ICuentaService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IUserServices _userService;
        private readonly IErrorManager _errorManagerSrv;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        /// <param name="userService"></param>
        /// <param name="errorManagerSrv"></param>
        public CuentaService(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IUserServices userService,
            IErrorManager errorManagerSrv)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _userService = userService;
            _errorManagerSrv = errorManagerSrv;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ValidationModel> Login(UserLogin_Dto request)
        {
            TokenResponse _response = new TokenResponse();
            try {
                var result = await _signInManager.PasswordSignInAsync(request.Login, request.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return await _userService.LoginUser(request.Login);
                }
                else
                {
                    _response.ValidationResults.Add(new ValidationResult("Login Incorrecto", new[] { "Credenciales incorrectas" }));
                    return _response;
                }
            }
            catch(System.Exception ex)
            {
                var jsonModel = JsonConvert.SerializeObject(request);
                throw _errorManagerSrv.AddError("xportsGenerico", "CuentaService_Login",ex,MethodBase.GetCurrentMethod(), jsonModel);
            }
            
        }
    }
    
   
}
