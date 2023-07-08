using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Requests
{
    public class AddCustomerCommand
    {
        public CustomerModel Customer { get; set; }
    }
}
