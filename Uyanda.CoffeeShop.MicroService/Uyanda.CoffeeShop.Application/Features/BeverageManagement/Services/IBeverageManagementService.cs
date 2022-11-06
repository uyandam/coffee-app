using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Requests.Results;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Services
{
    public interface IBeverageManagementService
    {
        Task<GetMenuResult> GetMenuAsync();
    }
}
