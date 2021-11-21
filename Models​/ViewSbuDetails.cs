using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ViewSbuDetails
    {
        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public string ContactOfficer { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PhoneNumbers { get; set; }
        public string Fax { get; set; }
        public string Email2 { get; set; }
        public string IdState { get; set; }
        public string StatusId { get; set; }
        public string Sbu { get; set; }
        public string Description { get; set; }
        public string SbuStatus { get; set; }
        public string Category { get; set; }
        public int Sn { get; set; }
        public DateTime? Datemove { get; set; }
        public string UserMove { get; set; }
    }
}
