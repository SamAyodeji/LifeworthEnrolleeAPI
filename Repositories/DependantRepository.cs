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
    public class DependantRepository : Repository<Dependant>, IDependantRepository
    {
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<DependantRepository> logger;
        public DependantRepository(DB9198_lifeworthContext dbContext,ILogger<DependantRepository> logger) :base(dbContext, logger)
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
        public async Task <IEnumerable<Dependant>> GetDependantByIDAsync(int IdEmployee)
        {
            return await lifeworthContext.Dependant.Where(m => m.IdEmployee == IdEmployee).ToListAsync();
        }
        //public async Task<Dependant> AddDependant(Dependant dependant)
        //{
        //   var result= await lifeworthContext.Dependant.AddAsync(dependant);
        //    await lifeworthContext.SaveChangesAsync();
        //    return result.Entity;
           
        //}
        public async Task<NewDependantDTO> AddDependant(NewDependantDTO newDependantDTO)
        {
            var ND = new Dependant
            {
                Name = newDependantDTO.Name,
               Surname = newDependantDTO.Surname,
               BirthDate = newDependantDTO.BirthDate,
               Sex = newDependantDTO.Sex,
               IdEmployee = newDependantDTO.IdEmployee,
               RelationType = newDependantDTO.RelationType

            };

            var done = await lifeworthContext.Dependant.AddAsync(ND);
            await lifeworthContext.SaveChangesAsync();
            return null;

        }

        public async Task<IEnumerable<Dependant>> GetDependantAsync(string DependantNo = null, string Surname = null, string FullName= null)
        {
            if(DependantNo != null)
            {
                return  await dB9198_LifeworthContext.Dependant.Where(m => m.EmployeeNo == DependantNo).ToListAsync();
            }
            if(Surname != null)
            {
                return await dB9198_LifeworthContext.Dependant.Where(m => m.Surname.ToLower() == Surname.ToLower()).ToListAsync();
            }
            if(FullName != null)
            {
                return await dB9198_LifeworthContext.Dependant.Where(m => m.Name.ToLower().Contains(FullName.ToLower())).ToListAsync();
            }
            return null;
        }

        
    }
}
