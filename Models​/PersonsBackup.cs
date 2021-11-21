using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PersonsBackup
    {
        public int IdCompany { get; set; }
        public string CompCode { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumbers { get; set; }
        public string Fax { get; set; }
        public string IdState { get; set; }
        public byte? PaymentGap { get; set; }
        public string RefNumber { get; set; }
        public string AgentCode { get; set; }
        public string Status { get; set; }
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
    }
}
