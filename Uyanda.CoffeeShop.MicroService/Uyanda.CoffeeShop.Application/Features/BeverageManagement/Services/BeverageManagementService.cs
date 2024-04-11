using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests.Results;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Persistence;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Services
{
    public class BeverageManagementService: IBeverageManagementService
    {
        private readonly IBeverageAccessor beverageAccessor;

        public BeverageManagementService(IBeverageAccessor beverageAccessor)
        {
            this.beverageAccessor = beverageAccessor;
        }

        public async Task<GetMenuResult> GetMenuAsync()
        {
            var result = await beverageAccessor.GetMenuAsync();

            return new GetMenuResult { menu = result };
        }

        //public async Task<PlaceOrderResult> PlaceOrderAsync(PlaceOrderCommand order)
        //{

        //}



    }
}
