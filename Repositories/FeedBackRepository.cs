using LifeworthAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeworthAPI.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using LifeworthAPI.Helper.Account;
using Microsoft.AspNetCore.Mvc;

namespace LifeworthAPI.Repositories
{
    public class FeedBackRepository : Repository<FeedBack>, IFeedBackRepository
    {
        public readonly DB9198_lifeworthContext dB9198_LifeworthContext;
        public readonly ILogger<FeedBackRepository> logger;

        public FeedBackRepository(DB9198_lifeworthContext dbContext, ILogger<FeedBackRepository> logger) : base(dbContext, logger)
        {
            this.logger = logger;
        }
        public DB9198_lifeworthContext lifeworthContext
        {
            get
            {
                return dbContext as DB9198_lifeworthContext;
            }
        }

        //public async Task<FeedBack> AddFeedBack(FeedBack feedBack)
        //{
        //    var result = await lifeworthContext.FeedBack.AddAsync(feedBack);
        //    await lifeworthContext.SaveChangesAsync();
        //    return result.Entity;
        //}

        //public Task<ActionResult<FeedbackDTO>> AddFeedBack(FeedbackDTO feedbackDTO)
        //{

        //    var Feeds = new FeedBack
        //    {
        //        Name = feedbackDTO.Name,
        //        FeedBack1 = feedbackDTO.FeedBack

        //    };

        //     lifeworthContext.FeedBack.AddAsync(Feeds);
        //    lifeworthContext.SaveChangesAsync();
        //    return null;
        //}

        public async Task<FeedbackDTO> AddFeedBAck(FeedbackDTO feedbackDTO)
        {

            var Feeds = new FeedBack
            {
                Name = feedbackDTO.Name,
                FeedBackDate =feedbackDTO.FeedBackDate,
                FeedBack1 = feedbackDTO.FeedBack

            };

            var done = await lifeworthContext.FeedBack.AddAsync(Feeds);
             await lifeworthContext.SaveChangesAsync();
            return null;
        }
    }
}
