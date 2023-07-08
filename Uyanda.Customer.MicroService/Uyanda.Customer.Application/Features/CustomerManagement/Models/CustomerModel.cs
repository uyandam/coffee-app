using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Models
{
    public class CustomerModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Points { get; set; }

        public int ContactDetailsId { get; set; }
        public ContactDetailsModel? ContactDetails { get; set; }
    }
}
