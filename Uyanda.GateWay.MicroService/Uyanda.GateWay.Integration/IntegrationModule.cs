using Microsoft.Extensions.DependencyInjection;
using Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService;
using Uyanda.GateWay.Integration.Microservices.CoffeeShopMicroService;

namespace Uyanda.GateWay.Integration
{
    public static class IntegrationModule
    {
        public static IServiceCollection AddIntegrationModule(this IServiceCollection services)
        {
            services.AddTransient<ICoffeeShopMicroService, CoffeeShopMicroService>();

            return services;
        }
    }
}