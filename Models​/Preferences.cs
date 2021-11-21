using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Preferences
    {
        public int IdPreferences { get; set; }
        public string CompanyName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string IdState { get; set; }
        public string Telephone01 { get; set; }
        public string Telephone02 { get; set; }
        public string Fax { get; set; }
        public string Website { get; set; }
        public string CoyRegCode { get; set; }
        public string SoftwareName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPosition { get; set; }
        public string Email { get; set; }
        public DateTime? WorkingDate { get; set; }
        public bool? Post2Mbk { get; set; }
        public int? Gap4PlcRenewAlert { get; set; }
        public string FinYearBegin { get; set; }
        public string MailType { get; set; }
        public string Smtphost { get; set; }
        public string Smtpport { get; set; }
        public string SenderAddress { get; set; }
        public string SenderName { get; set; }
        public string ReplyToAddress { get; set; }
        public string IdApplication { get; set; }
        public bool? Post2Gl { get; set; }
        public string MoneyDatabaseName { get; set; }
        public string IdBizUnit { get; set; }
        public string IdLocation { get; set; }
        public string IdProductLine { get; set; }
        public DateTime? SwitchVal { get; set; }
        public bool? ShwPrdBnfitOnScan { get; set; }
        public string Money4LodgementAcctNo { get; set; }
        public string Money4PaymentAcctNo { get; set; }
        public string CapitationAcctNo { get; set; }
        public string PremiumAcctNo { get; set; }
        public string ClaimsAcctNo { get; set; }
        public string CommissionAcctNo { get; set; }
        public byte? PreferedFormat { get; set; }
        public string Nhiscode { get; set; }
        public bool? Force4Authorization { get; set; }
        public string Nhisfolder { get; set; }
        public bool? AutoCodeCompany { get; set; }
        public string CompanyCodeSpName { get; set; }
        public bool? AutoCodeProvider { get; set; }
        public string ProviderCodeSpName { get; set; }
        public bool? AutoCodeEnrolleeNo { get; set; }
        public string EnrolleeNoSpName { get; set; }
        public string DependantNoSpName { get; set; }
        public bool? AutoCodeReferralAuthen { get; set; }
        public string ReferralAuthenSpName { get; set; }
        public string DefaultPayType { get; set; }
        public int? AlertGap4Feedback { get; set; }
        public bool? PreAuthorizationWrkFlow { get; set; }
        public DateTime? LastCapDate { get; set; }
        public bool? AutoCodePolicyCode { get; set; }
        public string PolicyCodeSpName { get; set; }
        public bool? UseBranchLogin { get; set; }
        public bool? UseManualReferral { get; set; }
        public decimal? Vat { get; set; }
        public string ReceivableAcctNo { get; set; }
        public string PayableAcctNo { get; set; }
        public string ReimburseAcctNo { get; set; }
        public string PreEmployAcctNo { get; set; }
        public string ClinicRunAcctNo { get; set; }
        public string AmbulanceServAcctNo { get; set; }
        public string WhtacctNo { get; set; }
        public DateTime? LastCommDate { get; set; }
    }
}
