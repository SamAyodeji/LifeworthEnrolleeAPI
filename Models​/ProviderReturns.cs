using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderReturns
    {
        public int IdReturns { get; set; }
        public int? IdProvider { get; set; }
        public DateTime? TreatmentDate { get; set; }
        public string PatientName { get; set; }
        public string PolicyNo { get; set; }
        public string EmployeeNo { get; set; }
        public byte? Age { get; set; }
        public string PersonTreated { get; set; }
        public string TransType { get; set; }
        public decimal? TotalCost { get; set; }
        public string IdTreatmentResult { get; set; }
        public string ErrorNotes { get; set; }
        public int? IdDiagnosis { get; set; }
        public int? IdEmployee { get; set; }
        public bool? Treated { get; set; }
        public decimal? ProviderBill { get; set; }
        public decimal? ApprovedAmt { get; set; }
        public string Fee4Serv { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public string Reason { get; set; }
        public DateTime? TransactionDate { get; set; }
        public byte? Reversal { get; set; }
        public string VoucherNo { get; set; }
        public int? IdSpeciality4Claims { get; set; }
        public string CapturedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? IdReferral { get; set; }
        public bool? AdmissionBased { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public bool? Posted { get; set; }
        public int? ReqDtlId { get; set; }
        public int? ReqMstId { get; set; }
        public int? PrvRetId { get; set; }
        public bool? NotWithPrv { get; set; }
        public bool? FromCollection { get; set; }
        public DateTime? GlpostDate { get; set; }
        public string PostedBy { get; set; }
        public string Notes { get; set; }
        public bool? RequireOverride { get; set; }
        public string OverrideBy { get; set; }
        public DateTime? OverrideDate { get; set; }
        public int? IdProvRtnMaster { get; set; }
        public string BillCode { get; set; }
        public int? IdReason { get; set; }
        public string Referral { get; set; }

        public virtual TreatmentResult IdTreatmentResultNavigation { get; set; }
    }
}
