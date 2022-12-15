using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;

namespace Uyanda.Customer.Persistence.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Points { get; set; }

        public ContactDetailsEntity? ContactDetails { get; set; }
    }
}
