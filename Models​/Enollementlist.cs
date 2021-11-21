using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Enollementlist
    {
        public int IdEmployee { get; set; }
        public int? IdCompany { get; set; }
        public string StaffNo { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string PhoneNo { get; set; }
        public string Plan { get; set; }
        public DateTime? Tdate { get; set; }
        public string TempEnrolleeNo { get; set; }
        public bool? Vetted { get; set; }
        public bool? Checking { get; set; }
    }
}
