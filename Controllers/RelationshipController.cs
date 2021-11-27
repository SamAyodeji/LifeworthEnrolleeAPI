using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Helper;
using LifeworthAPI.Helper.Account;
using LifeworthAPI.Interfaces;
using LifeworthAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LifeworthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelationshipController : ControllerBase

    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IRelationTypeRepository relationTypeRepository;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;


        public RelationshipController(IUnitOfWork unitOfWork, General general, IRelationTypeRepository relationTypeRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.relationTypeRepository = relationTypeRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RelationshipDTO>>> Getrelationships()
        {

            return (await relationTypeRepository.GetRelationships()).ToList();
            


        }




    }
}
