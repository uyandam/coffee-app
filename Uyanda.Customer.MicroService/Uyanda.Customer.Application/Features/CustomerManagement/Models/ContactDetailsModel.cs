﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.Customer.Application.Features.CustomerManagement.Models
{
    public class ContactDetailsModel
    {
        public int Id { get; set; }

        public string? EmailAddress { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
