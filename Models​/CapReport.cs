using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CapReport
    {
        public int IdCapitation { get; set; }
        public string PolicyNo { get; set; }
        public int IdProvider { get; set; }
        public string Narration { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? IdCompany { get; set; }
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string Rtype { get; set; }
        public string CompanyName { get; set; }
        public string PolicyDetail { get; set; }
        public string ProviderName { get; set; }
        public string Name { get; set; }
    }
}
