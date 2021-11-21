using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Repositories;
using LifeworthAPI.Models;

namespace LifeworthAPI.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {


        Task<IEnumerable<Product>> GetPolicyByIDAsync(string ID_Product);
    }
}
