using LifeworthAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<DependantRepository> logger;
        public ProductRepository(DB9198_lifeworthContext dbContext, ILogger<DependantRepository> logger) : base(dbContext, logger)
        {
            this.logger = logger;
        }

        public ProductRepository(DbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }

        public DB9198_lifeworthContext lifeworthContext
        {
            get
            {
                return dbContext as DB9198_lifeworthContext;
            }
        }
        public async Task<IEnumerable<Product>> GetPolicyByIDAsync(string ID_Product)
        {
            return await lifeworthContext.Product.Where(m => m.IdProduct == ID_Product).ToListAsync();
        }

        public async Task<IEnumerable<ViewProductDTO>> Getproducts()
        {
            return await lifeworthContext.Product.Select(x => ToDTO(x)).ToListAsync();
        }

        private static ViewProductDTO ToDTO(Product pro) =>
         new ViewProductDTO
         {
             IdProduct = pro.IdProduct,
             Name = pro.Name

         };

    
}
}
