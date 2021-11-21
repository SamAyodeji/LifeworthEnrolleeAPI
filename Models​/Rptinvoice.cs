using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Rptinvoice
    {
        public int BillId { get; set; }
        public short? CompanyNo { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string InvoiceNo { get; set; }
        public decimal? AmtExpected { get; set; }
        public DateTime? TransDate { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public string EmployeeNo { get; set; }
        public string Remark { get; set; }
        public string BillType { get; set; }
        public bool? Cancel { get; set; }
        public bool? Paid { get; set; }
        public bool? Part { get; set; }
        public decimal? Remainbal { get; set; }
        public bool? Confirmed { get; set; }
    }
}
