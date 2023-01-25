using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Persistence;
using Uyanda.CoffeeShop.Persistence.Entities;
using AutoMapper;
using System;
using Uyanda.CoffeeShop.Application.Features.BeverageManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace Uyanda.CoffeeShop.Persistence.Accessors
{
    public class BeverageAccessor : IBeverageAccessor
    {
        private readonly LocalDbContext localDbContext;
        private readonly IMapper mapper;

        public BeverageAccessor(IUnitOfWork unitOfWork, IMapper mapper)
        {
            Console.WriteLine("-------------- BROGEND -----------");
            localDbContext = (LocalDbContext)unitOfWork;
            this.mapper = mapper;
        }

        public async Task<BeverageModel[]> GetMenuAsync()
        {
            var menu = await localDbContext.Beverages
                .AsNoTracking()
                .Include(row => row.BeverageName)
                .Include(row => row.BeverageType)
                .Include(row => row.BeverageSize)
                .Include(row => row.Price)
                .ToArrayAsync();

            return menu.Select(ToModel).ToArray();
        }
            
      

        private BeverageTypeEntity ToEntity (BeverageTypeModel model) => mapper.Map<BeverageTypeEntity>(model);
        private BeverageTypeModel ToModel (BeverageTypeEntity entity) => mapper.Map<BeverageTypeModel>(entity);

        private BeverageNameEntity ToEntity(BeverageNameModel model) => mapper.Map<BeverageNameEntity>(model);
        private BeverageNameModel ToModel(BeverageNameEntity entity) => mapper.Map<BeverageNameModel>(entity);

        private BeverageEntity ToEntity(BeverageModel model) => mapper.Map<BeverageEntity>(model);
        private BeverageModel ToModel(BeverageEntity entity) => mapper.Map<BeverageModel>(entity);

        
    }
}
