using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Schedule
    {
        public int Sn { get; set; }
        public string PolNo { get; set; }
        public int? IdCompany { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Enrollees { get; set; }
        public decimal? TotalPremium { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Payable { get; set; }
        public DateTime? Transdate { get; set; }
        public string Userid { get; set; }
    }
}
