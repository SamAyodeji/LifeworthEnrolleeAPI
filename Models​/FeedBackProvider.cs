using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class FeedBackProvider
    {
        public int IdFeedBack { get; set; }
        public int? IdProvider { get; set; }
        public DateTime? FeedBackDate { get; set; }
        public string IdNextActionType { get; set; }
        public DateTime? NextActiondate { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? TransDate { get; set; }
        public string Feedback { get; set; }
        public bool? Done { get; set; }
    }
}
