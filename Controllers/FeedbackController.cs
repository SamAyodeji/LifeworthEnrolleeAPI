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
using LifeworthAPI.Helper.Account;
using Microsoft.EntityFrameworkCore;

namespace LifeworthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedBackController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;
        private readonly General general;
        public IConfiguration config;
        private readonly IFeedBackRepository feedBackRepository;
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext1;
        public FeedBackController(IUnitOfWork unitOfWork, General general, IFeedBackRepository feedBackRepository)
        {
            this.unitOfWork = unitOfWork;
            this.general = general;
            this.feedBackRepository = feedBackRepository;
        }



        //[HttpPost]
        //public async Task<ActionResult<FeedBack>> Feedback([FromBody] FeedBack feedbackDTO)
        //{
        //    try

        //    {
        //        var insertfb = await feedBackRepository.AddFeedBack(feedbackDTO);

        //        return Ok();



        //    }
        //    catch(Exception e)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError);
        //    }
        //}



        [HttpPost]
        public async Task<ActionResult<FeedbackDTO>> Feedback([FromBody] FeedbackDTO feedbackDTO)
        {
            try

            {
                var insertfb = await feedBackRepository.AddFeedBAck(feedbackDTO);

                return Ok(  "Submitted Succesfully" );



            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
