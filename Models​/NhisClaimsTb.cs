using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class NhisClaimsTb
    {
        public int Formno { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime TreatmentDate { get; set; }
        public DateTime? DispensingDate { get; set; }
        public string EmployeeName { get; set; }
        public string Sex { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string IdProvider { get; set; }
        public string IdCompany { get; set; }
        public string ProviderName { get; set; }
        public string Drname { get; set; }
        public string Ppcode { get; set; }
        public string Ppname { get; set; }
        public string PharmacistName { get; set; }
        public decimal? ConsultationFee { get; set; }
        public string Diagnosis { get; set; }
        public string Investigation { get; set; }
        public string Procedure { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
