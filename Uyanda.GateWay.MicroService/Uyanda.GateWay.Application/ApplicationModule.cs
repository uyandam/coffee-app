using Microsoft.Extensions.DependencyInjection;
using Uyanda.GateWay.Application.Microservices.Services;
namespace Uyanda.GateWay.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<IGateWayManagementService, GateWayManagementService>();

            return services;
        }
    }
}