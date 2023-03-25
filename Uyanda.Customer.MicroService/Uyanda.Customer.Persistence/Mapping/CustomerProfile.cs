using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;
using Uyanda.Customer.Persistence.Entities;

namespace Uyanda.Customer.Persistence.Mapping
{
    public class CustomerProfile: Profile 
    {
        public CustomerProfile()
        {
            CreateMap<CustomerModel, CustomerEntity>();
            CreateMap<CustomerEntity, CustomerModel>();
        }
        
    }
}
