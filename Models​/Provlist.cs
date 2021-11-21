using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Provlist
    {
        public int? IdEmployee { get; set; }
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public string IdProduct { get; set; }
        public string ImageFileName { get; set; }
        public int? IdCompany { get; set; }
        public int? IdProvider { get; set; }
    }
}
