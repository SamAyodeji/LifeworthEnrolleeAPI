using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Rptexpiring
    {
        public int? MrecId { get; set; }
        public short? CompanyNo { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public short? EmployeeNo { get; set; }
        public decimal? NewBill { get; set; }
        public decimal? AddedBill { get; set; }
        public decimal? Payment { get; set; }
        public decimal? Balance { get; set; }
        public string PaymentAnalysis { get; set; }
        public string Remark { get; set; }
        public string Status { get; set; }
    }
}
