using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Referrals
    {
        public int IdReferral { get; set; }
        public int? IdProvider { get; set; }
        public int? IdPrvReferred { get; set; }
        public DateTime? RequestDate { get; set; }
        public string EmployeeNo { get; set; }
        public int? IdCompany { get; set; }
        public string PolicyNo { get; set; }
        public string PatientName { get; set; }
        public byte? Age { get; set; }
        public string PersonTreated { get; set; }
        public int? IdDiagnosis { get; set; }
        public string CapturedBy { get; set; }
        public int? IdReferralReason { get; set; }
        public string ReferredBy { get; set; }
        public DateTime? ReferredDate { get; set; }
        public string AuthorizationNo { get; set; }
        public string Comments { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? IdReturns { get; set; }
        public string CallerName { get; set; }
        public string IdLocation { get; set; }
        public string Investigations { get; set; }
        public string Sex { get; set; }
    }
}
