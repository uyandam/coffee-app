using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.Models;

namespace Uyanda.GateWay.Application.Microservices.CoffeeShopMicroService
{
    public interface ICoffeeShopMicroService
    {
        Task<BeverageModel []> MenuAsync();
    }
}
