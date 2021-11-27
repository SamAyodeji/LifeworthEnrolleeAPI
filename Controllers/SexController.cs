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
    public class SexController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly ISexRepository sexRepository;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;



        public SexController(IUnitOfWork unitOfWork, General general, ISexRepository sexRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.sexRepository = sexRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SexDTO>>> Getsex()
        {

            return (await sexRepository.Getsex()).ToList();



        }










    }
}
