using Microsoft.Extensions.DependencyInjection;
using Uyanda.Customer.Application.Features.CustomerManagement.Services;

namespace Uyanda.Customer.Application
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddTransient<ICustomerManagementService, CustomerManagementService>();

            return services;
        }
    }
}