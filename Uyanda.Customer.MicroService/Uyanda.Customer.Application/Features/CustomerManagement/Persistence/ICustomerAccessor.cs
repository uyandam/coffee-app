using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Persistence
{
    public interface ICustomerAccessor
    {
        Task<CustomerModel[]> GetCustomersAsync();
    }
}
