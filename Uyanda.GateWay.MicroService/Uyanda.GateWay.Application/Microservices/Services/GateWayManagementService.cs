using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.Requests.Results;
using Uyanda.GateWay.Application.Microservices.Models;
using Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService;
using Uyanda.GateWay.Application.Microservices.ForeignCurrencyMicroService;

namespace Uyanda.GateWay.Application.Microservices.Services
{
    public class GateWayManagementService: IGateWayManagementService
    {
        private readonly ICoffeeShopMicroService coffeeShopMicroService;
        private readonly IForeignCurrencyMicroService foreignCurrencyMicroService;

        public GateWayManagementService(ICoffeeShopMicroService coffeeShopMicroService, IForeignCurrencyMicroService foreignCurrencyMicroService)
        {
            this.coffeeShopMicroService = coffeeShopMicroService;

            this.foreignCurrencyMicroService = foreignCurrencyMicroService;
        }

        public async Task<BeverageModel[]> MenuAsync()
        {
            var result = await coffeeShopMicroService.MenuAsync();

            return result;
        }

        public async Task<ExchangeRateModel> ExchangeRate(ExchangeRateModel exchangeRate)
        {
            var result = await foreignCurrencyMicroService.GetExchangeRateAsync(exchangeRate.SourceCurrency, exchangeRate.DestinationCurrency);

            return result;

        }
    }
}
