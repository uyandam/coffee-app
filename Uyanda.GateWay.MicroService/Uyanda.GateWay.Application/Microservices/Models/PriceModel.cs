using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.GateWay.Application.Microservices.Models
{
    public class PriceModel
    {
       public int Id { get; set; }

        public string Currency { get; set; }

        public decimal Price { get; set; }
    }
}
