using Microsoft.Extensions.DependencyInjection;
using Uyanda.ForeignCurrency.Application.Integration;
using Uyanda.ForeignCurrency.Integration.ApiLayer;


namespace Uyanda.ForeignCurrency.Integration
{
    public static class IntegrationModule
    {
        public static IServiceCollection AddIntegrationModule(this IServiceCollection services)
        {
            //services.AddTransient<IApiLayerIntegration, ApiLayerIntegration>();
            services.AddHttpClient<IApiLayerIntegration, ApiLayerIntegration>();
            return services;
        }
    }
}