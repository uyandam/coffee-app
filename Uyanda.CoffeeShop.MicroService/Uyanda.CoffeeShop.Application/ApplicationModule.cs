using Microsoft.Extensions.DependencyInjection;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Services;


namespace Uyanda.CoffeeShop.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<IBeverageManagementService, BeverageManagementService>();

            return services;
        }
    }
}