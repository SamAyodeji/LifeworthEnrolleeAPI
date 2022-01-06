using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LifeworthAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Helper;
using LifeworthAPI.DTO.Account;
using LifewortAPI.DTO.Account;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class LoginController : ControllerBase

    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IDependantRepository dependantRepository;
        private readonly IEmployeeRepository employeeRepository;
        private readonly IProductRepository productRepository1;
        //public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;
        private readonly IHttpContextAccessor httpContextAccessor;
        public LoginController(IUnitOfWork unitOfWork, General general, IEmployeeRepository employeeRepository, IDependantRepository dependantRepository, IHttpContextAccessor httpContextAccessor, IProductRepository productRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.dependantRepository = dependantRepository;
            this.employeeRepository = employeeRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.productRepository1 = productRepository;
        }
        //POST api/Value
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoginRequestDTO requestDTO)
        {
            try
            {
                var enrollee = await unitOfWork.Employees.GetEmployeeByEmployeeNoAsync(requestDTO.employeeNo);
                
                if (enrollee != null)
                {
                    //compare password
                    // var encodedPassword = general.generatehash(requestDTO.Password, Convert.FromBase64String(provider.PasswordSalt));
                    
                    var PhoneNo = enrollee.PhoneNo;
                    if (enrollee.PhoneNo == PhoneNo)
                    {

                        // var badt = await productRepository1.GetPolicyByIDAsync(enrollee.IdProduct);
                        var badt = await productRepository1.GetPolicyByIDAsync(enrollee.IdProduct);
                        var bdt = badt.Select(x => x.BandType).FirstOrDefault();
                        
                        //var typeget = Getdependant(string ID_Product);


                        //credentails correct
                        return Ok(new LoginResponseDTO
                        {

                            token = general.GenerateToken(enrollee.EmployeeNo),
                            EmployeeNo = enrollee.EmployeeNo,
                            Gender = enrollee.Sex,
                            Name = enrollee.Surname, 
                            FullName = enrollee.FullName,
                            Policy = enrollee.CurrentIdPolicy,
                            image = $"{httpContextAccessor.HttpContext.Request.Scheme.ToString()}:\\{httpContextAccessor.HttpContext.Request.Host.ToString()}\\image\\{enrollee.ImageFileName}",
                            id = enrollee.IdEmployee,
                            ID_Product = enrollee.IdProduct,
                            IdProvider = enrollee.IdProvider,
                           BandType = bdt.ToString(),
                        ResponseMessage = "Login Successful"
                            
                        });
                    }
                    return Problem(detail: "Incorrect login credentials");

                }
                return Problem(detail: "Incorrect login credentials");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        static ProductDTO products(Product x)
           =>
                new ProductDTO
                {
                    //IdProduct = x.IdProduct,
                    BandType = x.BandType,


                };

        //[HttpPut("")]
        //public async Task<IActionResult> UpdateEmployee(int IdEmployee, UpdateEmployeeDTO updateEmployeeDTO)
        //{
        //    try
        //    {
        //        if(IdEmployee != updateEmployeeDTO.id)
        //        {
        //            return BadRequest();
        //        }
        //        var edey = await employeeRepository.GetEmployee(IdEmployee);

        //        await employeeRepository.UpdateEmployees(updateEmployeeDTO);
        //        return Ok();
        //    }
        //    catch(Exception)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //}


        [HttpPut("UserUpdate")]
        public async Task<IActionResult> UpdateEmployee(int IdEmployee, UpdateEmployeeDTO updateEmployeeDTO)
        {
            try
            {
               
                //var edey = await employeeRepository.GetEmployee(IdEmployee);

                await employeeRepository.UpdateEmployee(IdEmployee, updateEmployeeDTO);
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        //public async Task<IEnumerable<ProductDTO>> Getdependant(string ID_Product)
        //{
        //    var product = await productRepository1.GetPolicyByIDAsync(ID_Product);

        //    // var dd = <IEnumerable<DependantDTO>>(dependant);
        //    return product.Select(x => products(x)).ToList();
        //    // return Dependantss(dependant);

        //    // private IEnumerable<DependantDTO> Dependantss(IEnumerable<Dependant> dependant)
        //    // {

        //    //        //IdEmployee,

        //    //     })
        //    //     throw new NotImplementedException();
        //    // }

        //    static ProductDTO products(Product x)
        //   =>
        //        new ProductDTO
        //        {
        //            IdProduct = x.IdProduct,
        //            BandType = x.BandType,


        //        };

        //}






        //[HttpGet("userid/dependant")]
        //public async Task<IEnumerable<DependantDTO>> Getdependant(int IdEmployee)
        //{
        //    var dependant = await dependantRepository.GetDependantByIDAsync(IdEmployee);

        //    // var dd = <IEnumerable<DependantDTO>>(dependant);
        //     return dependant.Select( x => Dependantss(x)).ToList();

        //    static DependantDTO Dependantss(Dependant x)
        //   =>
        //        new DependantDTO
        //        {
        //            IdDependant = x.IdDependant,
        //            Name = x.Name,

        //            IdEmployee = x.IdEmployee,
        //            Surname = x.Surname,
        //            EmployeeNo = x.EmployeeNo,
        //        };



        //}
        //[HttpPost("userid/NewDependant")]
        //public async Task<ActionResult<DependantDTO>> NewDependant([FromBody]Dependant dependant)
        //{
        //   await dependantRepository.AddDependant(dependant);

        //    return Ok();
        //}


    }

}
