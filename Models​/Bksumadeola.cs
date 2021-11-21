using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Bksumadeola
    {
        public string Formno { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime TreatmentDate { get; set; }
        public DateTime? ConsultancyDate { get; set; }
        public string EmployeeName { get; set; }
        public int? IdProvider { get; set; }
        public decimal? ChargesSent { get; set; }
        public decimal? ChargesApproved { get; set; }
        public int? IdCompany { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Day { get; set; }
        public string Protype { get; set; }
        public string UserId { get; set; }
        public decimal? RealChargSent { get; set; }
    }
}
