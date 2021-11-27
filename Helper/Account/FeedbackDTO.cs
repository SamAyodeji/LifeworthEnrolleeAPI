using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Helper.Account
{
    public class FeedbackDTO
    {
        //public long ID_Company { get; set; }
        public string FeedBack { get; set; }
        //public bool IsComplete { get; set; }
        public DateTime FeedBackDate { get; set; }
        public string Name { get; set; }
        public string Rate { get;  set; }
        public int IDProvider { get; set; }
    }

    
}

