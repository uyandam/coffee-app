using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<BeverageModel> Beverages { get; set; }

        public decimal TotalCost { get; set; }
    }
}
