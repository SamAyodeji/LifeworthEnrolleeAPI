using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ClaimsMtbDetailN
    {
        public int Sno { get; set; }
        public string Formno { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime TreatmentDate { get; set; }
        public DateTime? ConsultancyDate { get; set; }
        public string EmployeeName { get; set; }
        public string IdProvider { get; set; }
        public decimal? ConsultancyFee { get; set; }
        public string Diagnosis { get; set; }
        public string Classification { get; set; }
        public int? Qty { get; set; }
        public string Description { get; set; }
        public string Procedure { get; set; }
        public decimal? ChargesSent { get; set; }
        public decimal? ChargesApproved { get; set; }
        public string IdCompany { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string Comment { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Day { get; set; }
        public string Protype { get; set; }
        public string UserId { get; set; }
    }
}
