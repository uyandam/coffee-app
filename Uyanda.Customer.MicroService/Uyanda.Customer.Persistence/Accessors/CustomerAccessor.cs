using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.Customer.Application.Features.CustomerManagement.Models;
using Uyanda.Customer.Application.Features.CustomerManagement.Persistence;
using Uyanda.Customer.Persistence.Entities;
using Microsoft.EntityFrameworkCore;


namespace Uyanda.Customer.Persistence.Accessors
{
    public class CustomerAccessor: ICustomerAccessor
    {
        private readonly LocalDbContext localDbContext;
        private readonly IMapper mapper;

        public CustomerAccessor(IUnitOfWork unitOfWork, IMapper mapper)
        {
            localDbContext = (LocalDbContext)unitOfWork;
            this.mapper = mapper;
        }

        public async Task<CustomerModel[]> GetCustomersAsync()
        {
            var customers = await localDbContext.Customers
                .AsNoTracking()
                .Include(row => row.ContactDetails)
                .ToArrayAsync();

            return customers.Select(ToModel).ToArray();
        }

        public async Task<CustomerStatusModel> GetCustomerStatusAsync(CustomerModel customer)
        {
            var isCustomerFoundResult = await localDbContext.Customers
                .AsNoTracking()
                .Where(c => c.ContactDetails.PhoneNumber == customer.ContactDetails.PhoneNumber || 
                c.ContactDetails.EmailAddress == customer.ContactDetails.EmailAddress)
                .AnyAsync();

            if (isCustomerFoundResult)
            {
                var customerIdResult = await localDbContext.Customers
                    .AsNoTracking()
                    .Where(c => c.ContactDetails.PhoneNumber == customer.ContactDetails.PhoneNumber ||
                        c.ContactDetails.EmailAddress == customer.ContactDetails.EmailAddress)
                    .FirstAsync();

                return new CustomerStatusModel { CustomerId = customerIdResult.Id, IsFound = isCustomerFoundResult };
            }

            return new CustomerStatusModel { IsFound = isCustomerFoundResult };

        }

        private CustomerModel ToModel(CustomerEntity entity) => mapper.Map<CustomerModel>(entity);
    }
}
