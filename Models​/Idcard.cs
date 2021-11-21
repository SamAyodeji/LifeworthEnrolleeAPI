using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Idcard
    {
        public int IdIdcard { get; set; }
        public int? IdCompany { get; set; }
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string OtherName { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string BloodG { get; set; }
        public string Gt { get; set; }
        public DateTime? Dob { get; set; }
        public string Allergy { get; set; }
        public string ProviderN { get; set; }
        public string ProviderA1 { get; set; }
        public string ProviderA2 { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Product { get; set; }
        public string ExpDate { get; set; }
        public byte[] Photo2 { get; set; }
        public string Photo { get; set; }
    }
}
