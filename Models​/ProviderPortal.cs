using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderPortal
    {
        public int Sn { get; set; }
        public int? IdProvider { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Encounter { get; set; }
        public string Imgfile { get; set; }
    }
}
