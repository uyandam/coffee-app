using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;
using Uyanda.Customer.Application.Features.CustomerManagement.Requests;
using Uyanda.Customer.Application.Features.CustomerManagement.Requests.Results;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Services
{
    public interface ICustomerManagementService
    {
        Task<GetCustomersResult> GetCustomersAsync();
        Task<GetCustomerStatusResult> GetCustomerStatusAsync(GetCustomerStatusCommand customerStatus);
        Task<GetCustomerResult> GetCustomerResultAsync(GetCustomerCommand customer);
    }
}
