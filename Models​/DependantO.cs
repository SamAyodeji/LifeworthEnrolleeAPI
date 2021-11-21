using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DependantO
    {
        public int IdDependant { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdCompany { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string RelationType { get; set; }
        public int? IdSickness { get; set; }
        public string ImageFileName { get; set; }
        public string CauseOfDeath { get; set; }
        public int? IdProvider { get; set; }
        public string IdProduct { get; set; }
        public int? CurrentIdCapitation { get; set; }
        public string CurrentIdPolicy { get; set; }
        public int? CurrentIdPremiun { get; set; }
        public string StatusId { get; set; }
        public string Sex { get; set; }
        public string Genotype { get; set; }
        public string BloodGroup { get; set; }
        public string IdState { get; set; }
        public DateTime? Datemove { get; set; }
        public string Usermove { get; set; }
        public string TypeMove { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Inclusion { get; set; }
        public DateTime? IncDate { get; set; }
        public string ChangeProvFrom { get; set; }
        public DateTime? ChgDate { get; set; }
        public string Notes { get; set; }
        public string Idcard { get; set; }
        public DateTime? IdcardDate { get; set; }
        public short? IdcardTotal { get; set; }
        public bool? Checking { get; set; }
        public DateTime? CommenceDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? Vetted { get; set; }
    }
}
