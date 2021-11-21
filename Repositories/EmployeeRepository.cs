using LifeworthAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Mvc;
using LifewortAPI.DTO.Account;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        //public DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<EmployeeRepository> logger;
        public EmployeeRepository(DB9198_lifeworthContext dbContext, ILogger<EmployeeRepository> logger) : base(dbContext, logger)
        {
            
            this.logger = logger;
        }

        public async Task<IEnumerable<Employee>>GetEmployeeAsync( string surname, string employeeNo, string fullname)
        {
            if(fullname != null)
            {
               
                return await lifeworthContext.Employee.Where(m => m.FullName.ToLower().Contains(fullname.ToLower())).ToListAsync();
            }
            if(employeeNo != null)
            {
                
                return await lifeworthContext.Employee.Where(m => m.EmployeeNo == employeeNo).ToListAsync();
            }
            if (surname != null)
            {

                return await lifeworthContext.Employee.Where(m => m.Surname.ToLower() == surname.ToLower()).ToListAsync();
            }
            return null;



           // throw new NotImplementedException();
        }

        public async Task<Employee>GetEmployeeByEmployeeNoAsync(string employeeNo)
        {
           
           
                return await lifeworthContext.Employee.Where(m => m.EmployeeNo == employeeNo).FirstOrDefaultAsync();
           
           
        

        }

        public async Task<IActionResult> UpdateEmployee(int IdEmployee, UpdateEmployeeDTO updateEmployeeDTO)
        {
            var result = await lifeworthContext.Employee.FindAsync(IdEmployee);
            if (result!=null)
            {
                result.DateOfBrith = updateEmployeeDTO.DateOfBrith;
                result.Address01 = updateEmployeeDTO.Address01;
                result.Address02 = updateEmployeeDTO.Address02;
            }
             await lifeworthContext.SaveChangesAsync();
            return null;
        }


        //ANother Method to implement same Action

        //public async Task<Employee> UpdateEmployees(UpdateEmployeeDTO updateEmployeeDTO)
        //{
           
        //    var result = await lifeworthContext.Employee.FirstOrDefaultAsync(e=> e.IdEmployee == updateEmployeeDTO.id);
        //    if (result != null)
        //    {
        //        result.DateOfBrith = updateEmployeeDTO.DateOfBrith;
        //        result.Address01 = updateEmployeeDTO.Address01;
        //        result.Address02 = updateEmployeeDTO.Address02;
        //    }
           
        //        await lifeworthContext.SaveChangesAsync();
        //    return result;
        //}

        public async Task<Employee> GetEmployee(int IdEmployee)
        {
            return await lifeworthContext.Employee
                .FirstOrDefaultAsync(e => e.IdEmployee == IdEmployee);
        }

        public DB9198_lifeworthContext lifeworthContext
        {
            get
            {
                return dbContext as DB9198_lifeworthContext;
            }
        }
    }
}
