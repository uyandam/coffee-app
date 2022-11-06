using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;
using Uyanda.CoffeeShop.Persistence.Entities;

namespace Uyanda.CoffeeShop.Persistence.Mapping
{
    public class BeveragesProfile: Profile
    {
        public BeveragesProfile()
        {
            CreateMap<BeverageTypeModel, BeverageTypeEntity>();
            CreateMap<BeverageTypeEntity, BeverageTypeModel>();

            CreateMap<BeverageModel, BeverageEntity>();
            CreateMap<BeverageEntity, BeverageModel>();

            CreateMap<BeverageNameModel, BeverageNameEntity>();
            CreateMap<BeverageNameEntity, BeverageNameModel>();

            CreateMap<BeverageSizeModel, BeverageSizeEntity>();
            CreateMap<BeverageSizeEntity, BeverageSizeModel>();
        }
    }
}
