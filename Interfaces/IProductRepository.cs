using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Repositories;
using LifeworthAPI.Models;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {


        Task<IEnumerable<Product>> GetPolicyByIDAsync(string ID_Product);
        public Task<IEnumerable<ViewProductDTO>> Getproducts();

        public Task<IEnumerable<BuyProductDTO>> BuyProducts();

        Task<IEnumerable<Product>> GetBenefitByIDAsync(string ID_Product);
    }
}
