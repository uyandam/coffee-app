using Microsoft.Extensions.DependencyInjection;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Persistence;
using Uyanda.CoffeeShop.Persistence.Accessors;

namespace Uyanda.CoffeeShop.Persistence
{
    public static class PersistenceModule
    {
        public static IServiceCollection AddPersistenceModule(this IServiceCollection services)
        {
            services.AddTransient<IBeverageAccessor, BeverageAccessor>();
            services.AddTransient<IUnitOfWork, LocalDbContext>();
            return services;
        }
    }
}