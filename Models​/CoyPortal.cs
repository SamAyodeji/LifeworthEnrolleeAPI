using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CoyPortal
    {
        public int Sn { get; set; }
        public int? IdCompany { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Encounter { get; set; }
        public string Imgfile { get; set; }
    }
}
