﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Persistence.Entities
{
    public class PriceEntity
    {
        public int Id { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }
    }
}
