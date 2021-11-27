using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Models;
using LifeworthAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using LifeworthAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Repositories 
{
    public class RelationTypeRepository : Repository<RelationshipTb>, IRelationTypeRepository
    {

    
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<RelationTypeRepository> logger;
        public RelationTypeRepository(DB9198_lifeworthContext dbContext, ILogger<RelationTypeRepository> logger) : base(dbContext, logger)
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

        public async Task<IEnumerable<RelationshipDTO>> GetRelationships()
        {
            return await lifeworthContext.RelationshipTb.Select(x => ToDTO(x)).ToListAsync();
        }

        private static RelationshipDTO ToDTO(RelationshipTb relationshipTb) =>
         new RelationshipDTO
            {
                Code = relationshipTb.Code,
                Description = relationshipTb.Description
               
            };
        
    }
}
