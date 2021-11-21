using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Pcphist
    {
        public string EmployeeNo { get; set; }
        public DateTime TreatmentDate { get; set; }
        public string EmployeeName { get; set; }
        public string ProviderName { get; set; }
        public string Diagnosis { get; set; }
        public string Classification { get; set; }
        public string Description { get; set; }
    }
}
