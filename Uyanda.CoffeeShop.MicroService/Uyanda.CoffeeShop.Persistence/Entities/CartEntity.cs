using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Persistence.Entities
{
    public class CartEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<BeverageEntity> Beverages { get; set; }

        public string Currency { get; set; }


    }
}
