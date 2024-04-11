using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests
{
    public class PlaceOrderCommand
    {
        public CartModel cart { get; set; }
    }
}
