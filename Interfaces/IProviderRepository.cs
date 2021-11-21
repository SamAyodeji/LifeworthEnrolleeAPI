using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Models;

namespace LifeworthAPI.Interfaces
{
    public interface IProviderRepository : IRepository<Provider>
    {
        //Task<Provider> GetProviderByEmailAddressAsync(string email);

        IEnumerable<Provider> GetProvider(string BandType);
    }
}
