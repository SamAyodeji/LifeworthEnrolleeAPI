using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using LifeworthAPI.Helper.Account;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeworthAPI.Interfaces
{
    public interface IDependantRepository : IRepository<Dependant>
    {
        //Task<IEnumerable<Dependant>> GetDependantAsync(string DependantNo = null, string Surname = null, string FullName=null);

        Task <IEnumerable<Dependant>> GetDependantByIDAsync(int IdEmployee);

        //Task<Dependant> AddDependant(Dependant dependant);
        //Task AddDependant(DependantDTO dependantDTO);
        Task<NewDependantDTO> AddDependant(NewDependantDTO newDependantDTO);

        Task<IActionResult> UpdateDependant(int IdDependant, UpdateDependantDTO updatedependantDTO);
    }
}
