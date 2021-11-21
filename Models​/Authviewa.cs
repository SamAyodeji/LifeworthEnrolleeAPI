using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Authviewa
    {
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string ProviderName { get; set; }
        public string Claim { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Employeeid { get; set; }
        public string Provtype { get; set; }
    }
}
