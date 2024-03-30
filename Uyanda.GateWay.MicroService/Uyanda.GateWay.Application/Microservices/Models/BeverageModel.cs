using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uyanda.GateWay.Application.Microservices.Models
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

        public int PriceId { get; set; }

        public PriceModel Price { get; set; }

        public int Count { get; set; }
    }
}
