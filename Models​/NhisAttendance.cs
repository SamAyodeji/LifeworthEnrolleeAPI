using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class NhisAttendance
    {
        public int AttId { get; set; }
        public string FormCode { get; set; }
        public string ProviderId { get; set; }
        public DateTime? TransDate { get; set; }
        public string EmployeeNo { get; set; }
        public string Investigation { get; set; }
        public string Diagnosis { get; set; }
        public string Drugs { get; set; }
        public string Treatment { get; set; }
        public string Remark { get; set; }
    }
}
