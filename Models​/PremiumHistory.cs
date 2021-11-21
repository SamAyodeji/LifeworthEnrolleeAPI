using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PremiumHistory
    {
        public int IdPremiumHistory { get; set; }
        public int? IdPremium { get; set; }
        public string PolicyNo { get; set; }
        public int IdCompany { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? PayIdPremium { get; set; }
    }
}
