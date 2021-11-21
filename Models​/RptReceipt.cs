using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class RptReceipt
    {
        public int PayId { get; set; }
        public short? CompanyNo { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string ReceiptNo { get; set; }
        public string ModeOfPayment { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? Transdate { get; set; }
        public decimal? AmtPaid { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Begindt { get; set; }
        public DateTime? Enddt { get; set; }
        public string Bank { get; set; }
        public string Remark { get; set; }
        public string EmployeeNo { get; set; }
        public string BillType { get; set; }
    }
}
