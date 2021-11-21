using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Commissions
    {
        public int CommisionId { get; set; }
        public int? PremiumId { get; set; }
        public string PolicyNo { get; set; }
        public string IdProduct { get; set; }
        public DateTime? ValueDate { get; set; }
        public string AgentCode { get; set; }
        public string Narration { get; set; }
        public decimal? Premium { get; set; }
        public string TransType { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Rate { get; set; }
        public string PostPeriod { get; set; }
        public int? IdReqMaster { get; set; }
        public bool? Paid { get; set; }
        public bool? Regenerated { get; set; }
        public string VoucherNo { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
        public int? VatId { get; set; }
        public int? Reversal { get; set; }
    }
}
