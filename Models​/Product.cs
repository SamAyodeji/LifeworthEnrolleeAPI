using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Product
    {
        public Product()
        {
            Policy = new HashSet<Policy>();
            PolicyReschd = new HashSet<PolicyReschd>();
        }

        public int Sn { get; set; }
        public string IdProduct { get; set; }
        public string Name { get; set; }
        public decimal? Limit { get; set; }
        public string InsuredClass { get; set; }
        public short? MaxPeople { get; set; }
        public decimal? MinPremium { get; set; }
        public bool? CollectiveCover { get; set; }
        public decimal? CapitationAmount { get; set; }
        public string Classification { get; set; }
        public string PrdDocRepName { get; set; }
        public bool? PremiumByCalc { get; set; }
        public string PremCalcSpName { get; set; }
        public decimal? MinFee4Serv { get; set; }
        public string PremiumAcctNo { get; set; }
        public string CapitationAcctNo { get; set; }
        public string ClaimsAcctNo { get; set; }
        public string CommissionAcctNo { get; set; }
        public string PayableAcctNo { get; set; }
        public string ReceivableAcctNo { get; set; }

        public string BandType { get; set; }
        public virtual ICollection<Policy> Policy { get; set; }
        public virtual ICollection<PolicyReschd> PolicyReschd { get; set; }
        public string Type { get; internal set; }
        public string IndividualPrice { get;  set; }
        public string FamilyPrice { get;  set; }
        public string Benefits { get; set; }
    }
}
