﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models
{
    public class PriceModel
    {
       public int Id { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }
    }
}
