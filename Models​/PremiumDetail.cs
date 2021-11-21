using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PremiumDetail
    {
        public int IdPrmDetail { get; set; }
        public decimal? Amount { get; set; }
        public int? CompanyId { get; set; }
        public int? PayPrmId { get; set; }
        public int? DebitPrmId { get; set; }
        public string PolicyNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? PayManual { get; set; }
    }
}
