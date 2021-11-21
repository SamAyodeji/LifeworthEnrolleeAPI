using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Models;
using LifeworthAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using LifeworthAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LifeworthAPI.Repositories
{
    public class ProviderRepository : Repository<Provider>, IProviderRepository
    {
        private readonly ILogger<ProviderRepository> logger;
        public ProviderRepository(DB9198_lifeworthContext dbContext, ILogger<ProviderRepository>logger):base(dbContext, logger)
        {
            this.logger = logger;
        }
        //public  async Task<Provider>GetProviderByEmailAddressAsync(string email)
        //{

        //        return await lifeworthContext.Provider.Where(m => m.Email == email).FirstOrDefaultAsync();

        //}
        public DB9198_lifeworthContext lifeworthContext
        {
            get
            {
                return dbContext as DB9198_lifeworthContext;
            }
        }
        public IEnumerable<Provider> GetProvider(string BandType)
        {

            return lifeworthContext.Provider.Where(m => m.Bandtype == BandType).ToList();

        }
        
    }
}
