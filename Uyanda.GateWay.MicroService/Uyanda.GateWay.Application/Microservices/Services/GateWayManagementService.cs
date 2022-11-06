using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.Requests.Results;
using Uyanda.GateWay.Application.Microservices.Models;
using Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService;

namespace Uyanda.GateWay.Application.Microservices.Services
{
    public class GateWayManagementService: IGateWayManagementService
    {
        private readonly ICoffeeShopMicroService coffeeShopMicroService;

        public GateWayManagementService(ICoffeeShopMicroService coffeeShopMicroService)
        {
            this.coffeeShopMicroService = coffeeShopMicroService;
        }

        public async Task<BeverageModel[]> MenuAsync()
        {
            var result = await coffeeShopMicroService.MenuAsync();

            return result;
        }
    }
}
