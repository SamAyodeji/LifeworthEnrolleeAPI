using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class RequisitionDetails
    {
        public int IdReqDetails { get; set; }
        public int IdReqMaster { get; set; }
        public int IdProvider { get; set; }
        public string Narration { get; set; }
        public decimal? Amount2Pay { get; set; }
        public int? Enrollees { get; set; }
        public DateTime ValueDate { get; set; }
        public string ProcessedBy { get; set; }
        public byte? Posted { get; set; }
        public string TransType { get; set; }
        public string ChqInvNo { get; set; }
        public int? IdCallBack { get; set; }
        public string VoucherNo { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
        public string EmployeeNo { get; set; }
    }
}
