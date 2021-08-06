using Microsoft.Extensions.DependencyInjection;
using Services;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Extensions
{
    public static class ServiceConfigurationExtension
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IAdminService, AdminService>();
            services.AddTransient<IUserService, UserService>();
        }
    }
}
