using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PolicyReschd
    {
        public int IdPolicyReschd { get; set; }
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
        public string Comments { get; set; }
        public string Status { get; set; }
        public decimal? CapitationAmount { get; set; }
        public bool? Not4Capitation { get; set; }
        public string Reason4Reschd { get; set; }
        public string NewPolicyNo { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
