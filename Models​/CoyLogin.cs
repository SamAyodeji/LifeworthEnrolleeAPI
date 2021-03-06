using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CoyLogin
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
        public int? PaymentGap { get; set; }
        public string RefNumber { get; set; }
        public string AgentCode { get; set; }
        public DateTime? InitialRegDt { get; set; }
        public DateTime? BeginDt { get; set; }
        public DateTime? ExpiryDt { get; set; }
        public int? Balance { get; set; }
        public string StatusId { get; set; }
        public string Notes { get; set; }
        public string Comments { get; set; }
        public string GlprmAcctNo { get; set; }
        public string EmailAddress { get; set; }
        public string WebsiteAddress { get; set; }
        public string InitialPrdId { get; set; }
        public string City { get; set; }
        public string CompanyLogo { get; set; }
        public string DirectorName { get; set; }
        public string BizLine { get; set; }
        public int? StaffStrength { get; set; }
        public string BoardofDirectors { get; set; }
        public string Gsmnumber { get; set; }
        public string Datemove { get; set; }
        public string UserMove { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string OfficerCode { get; set; }
        public decimal? CoyPmt { get; set; }
        public int? EnrolleNo { get; set; }
        public int? BalanceC { get; set; }
        public int? BalanceT { get; set; }
        public int? BalancePre { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Encounter { get; set; }
        public string Imgfile { get; set; }
    }
}
