using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;
using Uyanda.Customer.Application.Features.CustomerManagement.Persistence;
using Uyanda.Customer.Application.Features.CustomerManagement.Requests.Results;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Services
{
    public class CustomerManagementService: ICustomerManagementService
    {
        private readonly ICustomerAccessor customerAccessor;

        public CustomerManagementService(ICustomerAccessor customerAccessor)
        {
            this.customerAccessor = customerAccessor;
        }

        public async Task<GetCustomersResult> GetCustomersAsync()
        {
            var result = await customerAccessor.GetCustomersAsync();

            return new GetCustomersResult { customers = result };
        }

    }
}
