﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.Customer.Persistence.Entities
{
    public class ContactDetailsEntity
    {
        public int Id { get; set; }

        public string? EmailAddress { get; set; }

        public string? PhoneNumber { get; set; }
    }
}