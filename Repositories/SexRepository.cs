using LifeworthAPI.Helper.Account;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LifeworthAPI.Repositories
{
    public class SexRepository : Repository<SexRepository>, ISexRepository
    {
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<SexRepository> logger;
        public SexRepository(DB9198_lifeworthContext dbContext, ILogger<SexRepository> logger) : base(dbContext, logger)
        {
            this.logger = logger;
        }

        public DB9198_lifeworthContext lifeworthContext
        {
            get
            {
                return dbContext as DB9198_lifeworthContext;
            }
        }


        public async Task<IEnumerable<SexDTO>> Getsex()
        {
            return await lifeworthContext.SexTb.Select(x => ToDTO(x)).ToListAsync();
        }

        private static SexDTO ToDTO(SexTb sexTb) =>
         new SexDTO
         {
             SexCode = sexTb.SexCode,
             SexDescription = sexTb.SexDescription

         };

        Task<SexTb> IRepository<SexTb>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Add(SexTb entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<SexTb> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SexTb> Find(Expression<Func<SexTb, bool>> expression)
        {
            throw new NotImplementedException();
        }

        SexTb IRepository<SexTb>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SexTb> IRepository<SexTb>.GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(SexTb entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<SexTb> entities)
        {
            throw new NotImplementedException();
        }
    }
}
