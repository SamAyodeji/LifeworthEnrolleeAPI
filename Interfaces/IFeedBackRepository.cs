using LifeworthAPI.Helper.Account;
using LifeworthAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Interfaces
{
   public interface IFeedBackRepository : IRepository<FeedBack>
    {

        //Task<FeedBack> AddFeedBack(FeedBack feedBack);
       Task<FeedbackDTO> AddFeedBAck(FeedbackDTO feedbackDTO);
    }
}
