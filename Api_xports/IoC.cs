using Api_xports.Features.Base;
using Api_xports.Features.Base.Validation;
using Api_xports.Features.Caja.services;
using Api_xports.Features.Cuenta.services;
using Api_xports.Features.Generico.services;
using Api_xports.Features.Recibos.Services;
using Api_xports.Features.reservas.Services;
using Api_xports.Features.SendEmail.Services;
using Api_xports.Features.User.Services;
using Api_xports.Helpers;
using Api_xports.Log;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.interfaces;

namespace Api_xports
{
    ///
    public static class IoC
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterSRServices(IServiceCollection services)
        {
            services.AddScoped<IErrorManager, ErrorManager>();
            services.AddScoped<ILogTrazaService, LogTrazaService>();
            services.AddScoped<ApiValidationFilterAttribute>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<ILog, XportsLog>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ICuentaService, CuentaService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IMaestroService, MaestrosService>();
            services.AddScoped<IReservasService, ReservasService>();
            services.AddScoped<ICajaService, CajaService>();
            services.AddScoped<IRecibosService, RecibosService>();
            services.AddScoped<IStoreProcedureRepository, StoreProcedureRepository>();
        }
    }
}
