using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CapitationX
    {
        public int IdCapitationX { get; set; }
        public string PolicyNo { get; set; }
        public int IdProvider { get; set; }
        public string Narration { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public string EmployeeNo { get; set; }
        public string ChqInvNo { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public byte? Reversal { get; set; }
        public string VoucherNo { get; set; }
        public bool? Posted { get; set; }
        public int? ReqDtlId { get; set; }
        public int? ReqMstId { get; set; }
        public int? CapPymtId { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
    }
}
