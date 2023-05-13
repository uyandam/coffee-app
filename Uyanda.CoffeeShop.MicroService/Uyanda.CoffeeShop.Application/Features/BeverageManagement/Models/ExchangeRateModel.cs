using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models
{
    public class ExchangeRateModel
    {
        public int Id { get; set; }

        public string SourceCurrency { get; set; }

        public string DestinationCurrency { get; set; }

        public decimal  ExchangeRate { get; set; }
    }
}
