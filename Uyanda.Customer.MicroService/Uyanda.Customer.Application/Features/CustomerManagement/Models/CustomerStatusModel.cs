using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Models
{
    public class CustomerStatusModel
    {
        public int CustomerId { get; set; }
        public bool IsFound { get; set; }

    }
}
