using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.CoffeeShop.Persistence.Entities
{
    public class BeverageEntity
    {
        public int Id { get; set; }


        public int BeverageNameId { get; set; }

        public BeverageNameEntity BeverageName { get; set; }

        public int BeverageTypeId { get; set; }

        public BeverageTypeEntity BeverageType { get; set; }

        public int BeverageSizeId { get; set; }

        public BeverageSizeEntity BeverageSize { get; set; }

        public int PriceId { get; set; }

        public PriceEntity Price { get; set; }

        public int Count { get; set; }
    }
}
