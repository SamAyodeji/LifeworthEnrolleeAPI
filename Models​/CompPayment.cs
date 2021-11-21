using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CompPayment
    {
        public string CompanyNo { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string ReceiptNo { get; set; }
        public string ModeOfPayment { get; set; }
        public string CheckNo { get; set; }
        public decimal? AmtExpected { get; set; }
        public DateTime? Date { get; set; }
        public decimal? AmtPaid { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public decimal? Balance { get; set; }
        public string Bank { get; set; }
        public string EmployeeNo { get; set; }
        public string PaymentAnalysis { get; set; }
        public string Remark { get; set; }
    }
}
