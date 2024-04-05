using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests.Results;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Persistence
{
    public interface IBeverageAccessor
    {
        // 1. Menu
        Task<BeverageModel[]> GetMenuAsync();

        // 2. Invoice



        // 3. Orders

        Task<PlaceOrderResult> PlaceOrderAsync(PlaceOrderCommand order);

        // 4. Currency cache

        //
    }
}
