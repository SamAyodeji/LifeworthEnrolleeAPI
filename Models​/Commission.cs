using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Commission
    {
        public int IdCommission { get; set; }
        public string AgentCode { get; set; }
        public int IdCompany { get; set; }
        public string PolicyNo { get; set; }
        public string Narration { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public string ChqInvNo { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public byte? Reversal { get; set; }
        public string VoucherNo { get; set; }
        public int? IdPremium { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
    }
}
