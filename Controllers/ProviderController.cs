using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Helper;
using LifeworthAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using LifeworthAPI.Models;
using LifeworthAPI.Repositories;
using LifeworthAPI.Helper.Account;

namespace LifeworthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IProviderRepository providerRepository;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;


        public ProviderController(IUnitOfWork unitOfWork, General general, IProviderRepository providerRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.providerRepository = providerRepository;
        }


        [HttpGet]
        public  IEnumerable<ProviderDTO> ProviderList(string BandType)
        {
            //ProviderName = ProviderDTO.ProviderName;
            var result = providerRepository.GetProvider(BandType);


            return  result.Select(x => ItemtoDTO(x)).ToList();
            // ProviderDTO(x)).ToList();


        }

        private static ProviderDTO ItemtoDTO(Provider x)
       =>
            new ProviderDTO
            {
                ProviderName = x.ProviderName,
                ID_Provider = x.IdProvider,
            };
        
    }
}
