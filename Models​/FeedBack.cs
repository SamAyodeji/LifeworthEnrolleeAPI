using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class FeedBack
    {
        public int IdFeedBack { get; set; }
        public int? IdCompany { get; set; }
        public DateTime? FeedBackDate { get; set; }
        public string IdNextActionType { get; set; }
        public DateTime? NextActionDate { get; set; }
        public string CapturedBy { get; set; }
        public DateTime? TransDate { get; set; }
        public string FeedBack1 { get; set; }
        public bool? Done { get; set; }
        public string Name { get; internal set; }
    }
}
