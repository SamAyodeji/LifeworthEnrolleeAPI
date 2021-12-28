﻿using System;
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
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IProductRepository productRepository1;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;


        public ProductController(IUnitOfWork unitOfWork, General general, IProductRepository productRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.productRepository1 = productRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Getdependant(string ID_Product)
        {
            var product = await productRepository1.GetPolicyByIDAsync(ID_Product);

            // var dd = <IEnumerable<DependantDTO>>(dependant);
            return product.Select(x => products(x)).ToList();
            // return Dependantss(dependant);

            // private IEnumerable<DependantDTO> Dependantss(IEnumerable<Dependant> dependant)
            // {

            //        //IdEmployee,

            //     })
            //     throw new NotImplementedException();
            // }

            static ProductDTO products(Product x)
           =>
                new ProductDTO
                {
                    IdProduct = x.IdProduct,
                    BandType = x.BandType,


                };

        }
        [HttpGet("Benefit")]
        public async Task<IEnumerable<BuyProductDTO>> GetBenefit(string ID_Product)
        {
            var Benefit = await productRepository1.GetBenefitByIDAsync(ID_Product);

            // var dd = <IEnumerable<DependantDTO>>(dependant);
            return Benefit.Select(x => product(x)).ToList();
           

            static BuyProductDTO product(Product x)
           =>
                new BuyProductDTO
                {
                   Benefits = x.Benefits,
                };

        }

        [HttpGet("ListProducts")]
        public async Task<ActionResult<IEnumerable<ViewProductDTO>>> GetProducts()
        {

            return (await productRepository1.Getproducts()).ToList();



        }
        [HttpGet("BuyProduct")]
        public async Task<ActionResult<IEnumerable<BuyProductDTO>>> GetProductsbyType()
        {

            return (await productRepository1.BuyProducts()).ToList();



        }

    }
}
