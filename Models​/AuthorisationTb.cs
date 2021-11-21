using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuthorisationTb
    {
        public string DrName { get; set; }
        public string PatientName { get; set; }
        public string PatientNumber { get; set; }
        public string DependantNo { get; set; }
        public string Sex { get; set; }
        public int? Age { get; set; }
        public DateTime? Date { get; set; }
        public bool Admission { get; set; }
        public bool Surgery { get; set; }
        public bool Procedure { get; set; }
        public string Name { get; set; }
        public string MhsNo { get; set; }
        public DateTime? Date1 { get; set; }
        public DateTime? TimeIn { get; set; }
        public string ProvisionalDiagnosis { get; set; }
        public string Summary { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
