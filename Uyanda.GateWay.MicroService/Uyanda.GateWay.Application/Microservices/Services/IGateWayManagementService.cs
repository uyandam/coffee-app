using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.GateWay.Application.Microservices.Requests.Results;
using Uyanda.GateWay.Application.Microservices.Models;

namespace Uyanda.GateWay.Application.Microservices.Services
{
    public interface IGateWayManagementService
    {
        Task<BeverageModel[]> MenuAsync();
    }
}
