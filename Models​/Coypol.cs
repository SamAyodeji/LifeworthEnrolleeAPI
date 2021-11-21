using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Coypol
    {
        public int? IdCompany { get; set; }
        public string IdProduct { get; set; }
        public string Name { get; set; }
        public int IdPolicy { get; set; }
        public string Status { get; set; }
        public string PolicyNo { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
