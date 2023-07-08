using Microsoft.Extensions.DependencyInjection;
using Uyanda.Customer.Application.Features.CustomerManagement.Persistence;
using Uyanda.Customer.Persistence.Accessors;

namespace Uyanda.Customer.Persistence
{
    public static class PersistenceModule
    {
        public static IServiceCollection AddPersistenceModule(this IServiceCollection services)
        {
            services.AddTransient<ICustomerAccessor, CustomerAccessor>();
            services.AddTransient<IUnitOfWork, LocalDbContext>();
            return services;
        }
    }
}