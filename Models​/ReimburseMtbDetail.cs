using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ReimburseMtbDetail
    {
        public string Formno { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime TreatmentDate { get; set; }
        public DateTime? ConsultancyDate { get; set; }
        public string EmployeeName { get; set; }
        public int? IdProvider { get; set; }
        public decimal? ConsultancyFee { get; set; }
        public string Diagnosis { get; set; }
        public string Classification { get; set; }
        public int? Qty { get; set; }
        public string Description { get; set; }
        public string Procedure { get; set; }
        public decimal? ChargesSent { get; set; }
        public decimal? ChargesApproved { get; set; }
        public string Comment { get; set; }
        public int? IdCompany { get; set; }
        public int Sno { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? Day { get; set; }
        public string Protype { get; set; }
        public string UserId { get; set; }
        public DateTime? Adddt { get; set; }
        public DateTime? Disdt { get; set; }
    }
}
