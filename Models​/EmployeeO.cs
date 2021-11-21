using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class EmployeeO
    {
        public int IdEmployee { get; set; }
        public string EmployeeNo { get; set; }
        public int? IdCompany { get; set; }
        public string StaffNo { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string IdState { get; set; }
        public string IdLga { get; set; }
        public string PhoneNo { get; set; }
        public DateTime? DateOfBrith { get; set; }
        public string JobLevel { get; set; }
        public int? IdProvider { get; set; }
        public string IdNationality { get; set; }
        public string NextOfKin { get; set; }
        public string IdOccupation { get; set; }
        public string Sex { get; set; }
        public int? IdBranch { get; set; }
        public string ImageFileName { get; set; }
        public string CurrentIdPolicy { get; set; }
        public DateTime? TerminalDate { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string IdProduct { get; set; }
        public byte? PaymentGap { get; set; }
        public int? CurrentIdCapitation { get; set; }
        public int? CurrentIdPremiun { get; set; }
        public DateTime? DateReceived { get; set; }
        public string StatusId { get; set; }
        public string Genotype { get; set; }
        public string BloodGroup { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string MartialStatus { get; set; }
        public DateTime? Datemove { get; set; }
        public string Usermove { get; set; }
        public string TypeMove { get; set; }
        public string Inclusion { get; set; }
        public DateTime? IncDate { get; set; }
        public string ChangeProvfrom { get; set; }
        public DateTime? ChgDate { get; set; }
        public string Idcard { get; set; }
        public DateTime? IdcardDate { get; set; }
        public short? IdcardTotal { get; set; }
        public string HistoryDesc { get; set; }
        public DateTime? HistoryDate { get; set; }
        public DateTime? HistoryTransDate { get; set; }
        public decimal? Balance { get; set; }
        public bool? Checking { get; set; }
        public bool? Newdep { get; set; }
        public bool? Vetted { get; set; }
        public DateTime? Tdate { get; set; }
    }
}
