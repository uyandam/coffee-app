using Microsoft.Extensions.DependencyInjection;
using Uyanda.ForeignCurrency.Application.Features.CurrencyManagement.Services;

namespace Uyanda.ForeignCurrency.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<ICurrencyManagementService, CurrencyManagementService>();

            return services;
        }
    }
}