using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CompanyO
    {
        public int IdCompany { get; set; }
        public string CompCode { get; set; }
        public string CompanyName { get; set; }
        public string ContactOfficer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumbers { get; set; }
        public string Fax { get; set; }
        public string Email2 { get; set; }
        public string IdState { get; set; }
        public string StatusId { get; set; }
        public byte? PaymentGap { get; set; }
        public string RefNumber { get; set; }
        public string AgentCode { get; set; }
        public DateTime? InitialRegDt { get; set; }
        public DateTime? BeginDt { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public int? Balance { get; set; }
        public string Datemove { get; set; }
        public string UserMove { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string OfficerCode { get; set; }
        public decimal? CoyPmt { get; set; }
        public int? Enrolleno { get; set; }
        public bool? Status { get; set; }
    }
}
