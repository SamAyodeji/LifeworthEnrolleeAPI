using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Depcount
    {
        public int IdCompany { get; set; }
        public string CompanyName { get; set; }
        public int? Enrollee { get; set; }
    }
}
