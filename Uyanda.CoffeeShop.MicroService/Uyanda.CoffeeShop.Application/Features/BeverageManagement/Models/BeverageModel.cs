using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;

namespace Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models
{
    public class BeverageModel
    {
        public int Id { get; set; }

        public int BeverageNameId { get; set; }

        public BeverageNameModel BeverageName { get; set; }

        public int BeverageTypeId { get; set; }

        public BeverageTypeModel BeverageType { get; set; }

       

        public int BeverageSizeId { get; set; }

        public BeverageSizeModel BeverageSize { get; set; }

        public decimal Price { get; set; }
    }
}
