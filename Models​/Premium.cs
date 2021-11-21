using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Premium
    {
        public int IdPremium { get; set; }
        public string PolicyNo { get; set; }
        public int IdCompany { get; set; }
        public string Narration { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public string EmployeeNo { get; set; }
        public string ChqInvNo { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public byte? Reversal { get; set; }
        public string VoucherNo { get; set; }
        public int? PrmPymtId { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
        public bool? Reversed { get; set; }
        public int? ReversalId { get; set; }
        public decimal? CrMemo { get; set; }
        public decimal? AmtSettled { get; set; }
        public decimal? Balance { get; set; }
        public string TransType { get; set; }
        public decimal? PrmAmount { get; set; }
        public decimal? EmpAmount { get; set; }
        public int? CallBackId { get; set; }
        public bool? PayManual { get; set; }
        public int? IdPolicy { get; set; }
        public int? IdPolicyUpdMaster { get; set; }
        public int? IdDeltaPlc { get; set; }
    }
}
