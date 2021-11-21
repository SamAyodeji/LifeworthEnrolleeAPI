using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifewortAPI.DTO.Account;
using LifeworthAPI.Helper.Account;
using LifeworthAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeworthAPI.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>>GetEmployeeAsync(string fullname, string employeeNo, string surname);
        Task<Employee>GetEmployeeByEmployeeNoAsync(string employeeNo);
        Task<IActionResult> UpdateEmployee(int IdEmployee, UpdateEmployeeDTO updateEmployeeDTO);
        Task<Employee> GetEmployee(int IdEmployee);
        //Task<Employee> UpdateEmployees(UpdateEmployeeDTO updateEmployeeDTO);
    }
}
