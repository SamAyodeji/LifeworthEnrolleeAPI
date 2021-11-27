using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Models;
using LifeworthAPI.Helper.Account;
using Microsoft.AspNetCore.Mvc;

namespace LifeworthAPI.Interfaces
{
   public interface IRelationTypeRepository: IRepository<RelationshipTb>
    {
        public Task<IEnumerable<RelationshipDTO>> GetRelationships();
    }
}
