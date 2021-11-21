using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CapView2
    {
        public string PolicyNo { get; set; }
        public int IdProvider { get; set; }
        public string Narration { get; set; }
        public decimal Amount { get; set; }
        public DateTime? ValueDate { get; set; }
        public int? IdCompany { get; set; }
        public string EmployeeNo { get; set; }
        public string ChqInvNo { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? TransactionDate { get; set; }
        public byte? Reversal { get; set; }
        public string VoucherNo { get; set; }
        public string Surname { get; set; }
        public string OtherName { get; set; }
        public string Rtype { get; set; }
        public int? IdBranch { get; set; }
        public string Sex { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string ProviderName { get; set; }
        public string Sbu { get; set; }
        public string CompCode { get; set; }
    }
}
