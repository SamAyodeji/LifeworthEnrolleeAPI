using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CapitationHistory
    {
        public int IdCapitationHistory { get; set; }
        public int? IdCapitation { get; set; }
        public string PolicyNo { get; set; }
        public int IdProvider { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? PayIdCapitation { get; set; }
    }
}
