using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderSpecialty
    {
        public int IdProviderSpecialty { get; set; }
        public int? IdProvider { get; set; }
        public int? IdAreaOfSpecialty { get; set; }
        public string Description { get; set; }
    }
}
