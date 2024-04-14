using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests.Results;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Services
{
    public interface IBeverageManagementService
    {

        // 1. Menu
        Task<GetMenuResult> GetMenuAsync();


        // 2. Invoice


        // 3. Orders
        //Task<PlaceOrderResult> PlaceOrderAsync(PlaceOrderCommand order);
        

        // 4. Currency cache

        // 5. Currency conversion


    }
}
