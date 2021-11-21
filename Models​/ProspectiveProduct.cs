using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProspectiveProduct
    {
        public int IdProspectProduct { get; set; }
        public string IdProduct { get; set; }
        public int? IdCompany { get; set; }
        public string Description { get; set; }
    }
}
