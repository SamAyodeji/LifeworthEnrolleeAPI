using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PrivateSchemeImport
    {
        public int IdImport { get; set; }
        public string FamilyCode { get; set; }
        public string StaffNo { get; set; }
        public string IdProduct { get; set; }
        public string ProviderName { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public DateTime? DateofBirth { get; set; }
        public string EmpType { get; set; }
        public string Sex { get; set; }
        public string MaritalStatus { get; set; }
        public string JobLevel { get; set; }
        public string Gsmnumber { get; set; }
        public string Email { get; set; }
        public DateTime? DateReceived { get; set; }
        public string CompCode { get; set; }
        public string Relationship { get; set; }
        public string Importfile { get; set; }
        public int? LineNo { get; set; }
        public string EnrolleeState { get; set; }
        public int? Posted { get; set; }
        public int? FndCnt { get; set; }
        public int? IdEmployee { get; set; }
    }
}
