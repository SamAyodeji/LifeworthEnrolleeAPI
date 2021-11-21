using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderReturnsMaster
    {
        public int IdProvRtnMaster { get; set; }
        public int? IdProvider { get; set; }
        public DateTime? CaptureDate { get; set; }
        public DateTime? BillPeriodBegin { get; set; }
        public DateTime? BillPeriodEnd { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? TotalApproved { get; set; }
        public string CapturedBy { get; set; }
        public string EndResult { get; set; }
        public string BillCode { get; set; }
        public string Narration { get; set; }
        public string Classification { get; set; }
        public string TransType { get; set; }
        public string EmployeeNo { get; set; }
        public string EmpType { get; set; }
    }
}
