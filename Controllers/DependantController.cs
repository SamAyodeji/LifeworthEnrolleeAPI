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
    [Route("api")]
    [ApiController]
    public class DependantController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IDependantRepository dependantRepository;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;


        public DependantController(IUnitOfWork unitOfWork, General general, IDependantRepository dependantRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.dependantRepository = dependantRepository;
        }



        [HttpGet("userid/dependant")]
        public async Task<IEnumerable<DependantDTO>> Getdependant(int IdEmployee)
        {
            var dependant = await dependantRepository.GetDependantByIDAsync(IdEmployee);

            // var dd = <IEnumerable<DependantDTO>>(dependant);
            return dependant.Select(x => Dependantss(x)).ToList();

            static DependantDTO Dependantss(Dependant x)
           =>
                new DependantDTO
                {
                    IdDependant = x.IdDependant,
                    Name = x.Name,

                    IdEmployee = x.IdEmployee,
                    Surname = x.Surname,
                    EmployeeNo = x.EmployeeNo,
                };



        }
        [HttpPost("userid/NewDependant")]
        public async Task<ActionResult<NewDependantDTO>> NewDependant([FromBody] NewDependantDTO newDependantDTO)
        {
            await dependantRepository.AddDependant(newDependantDTO);

            return Ok("Added Successfully");
           

                
        }

    }
}
