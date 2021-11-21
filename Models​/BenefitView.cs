using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class BenefitView
    {
        public int IdBenefit { get; set; }
        public string Name { get; set; }
        public string PrdBenefit { get; set; }
        public string IdProduct { get; set; }
    }
}
