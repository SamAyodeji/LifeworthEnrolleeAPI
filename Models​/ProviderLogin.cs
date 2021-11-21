using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderLogin
    {
        public int IdProvider { get; set; }
        public string ProviderName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string IdState { get; set; }
        public string IdLga { get; set; }
        public string PhoneNumbers { get; set; }
        public string Fax { get; set; }
        public short? IdDoctor { get; set; }
        public decimal? CapitationFixed { get; set; }
        public short? PaymentGap { get; set; }
        public decimal? CapitationRate { get; set; }
        public decimal? GrossCapitatn { get; set; }
        public int? MaxNo4Cap { get; set; }
        public int? IdSpecialty { get; set; }
        public string LinkCode { get; set; }
        public byte? CapitationByProduct { get; set; }
        public string IdCostLevel { get; set; }
        public string Type { get; set; }
        public string GlcapAcctNo { get; set; }
        public string GlclmAcctNo { get; set; }
        public bool? Not4Capitation { get; set; }
        public string Hnisnumber { get; set; }
        public string PrvCode { get; set; }
        public string RefNumber { get; set; }
        public string Comments { get; set; }
        public string Notes { get; set; }
        public string IdBank { get; set; }
        public string AccountNo { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string WebsiteAddress { get; set; }
        public string AccountName { get; set; }
        public string City { get; set; }
        public string BankLocation { get; set; }
        public string ContactPerson { get; set; }
        public int? BedCapacity { get; set; }
        public string PictureFileName { get; set; }
        public string TmpPrvCode { get; set; }
        public string Gsmnumber { get; set; }
        public string BankSortCode { get; set; }
        public bool? Proposal { get; set; }
        public string Status { get; set; }
        public bool? Specialist { get; set; }
        public string Bandtype { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string Encounter { get; set; }
        public string Imgfile { get; set; }
        public DateTime? LastLogin { get; set; }
        public int Sn { get; set; }
        public string Providercode { get; set; }
    }
}
