using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Requests.Results
{
    public class GetCustomersResult
    {  
        public IEnumerable<CustomerModel> customers { get; set; }
    }
}
