using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class EnrolleePortal
    {
        public int Sn { get; set; }
        public int? IdEmployee { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Encounter { get; set; }
        public string Imgfile { get; set; }
    }
}
