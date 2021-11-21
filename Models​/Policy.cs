using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Policy
    {
        public string PolicyNo { get; set; }
        public int? IdCompany { get; set; }
        public string IdProduct { get; set; }
        public string Narration { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? BeginDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobLevel { get; set; }
        public decimal? Premium { get; set; }
        public short? MaxPersons { get; set; }
        public decimal? GrossPremium { get; set; }
        public decimal? GrossDiscount { get; set; }
        public decimal? GrossReceipt { get; set; }
        public decimal? GrossClaims { get; set; }
        public decimal? CapitationRate { get; set; }
        public decimal? GrossCapitation { get; set; }
        public DateTime? TransDate { get; set; }
        public byte Activated { get; set; }
        public byte RenewFlag { get; set; }
        public byte? PrmPeriod { get; set; }
        public string AgentCode { get; set; }
        public decimal? CommissionRate { get; set; }
        public decimal? GrossFee4Service { get; set; }
        public decimal? Climit { get; set; }
        public string Comments { get; set; }
        public string Status { get; set; }
        public decimal? PremiumAmt { get; set; }
        public bool? Not4Capitation { get; set; }
        public string IdBizUnit { get; set; }
        public string IdProductLine { get; set; }
        public string IdLocation { get; set; }
        public string PolicyCode { get; set; }
        public int? EnrolleeCount { get; set; }
        public int? InsureCount { get; set; }
        public int IdPolicy { get; set; }
        public string Classification { get; set; }
        public string TenorType { get; set; }
        public decimal? AnnualPremium { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
