using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PrdBenefits
    {
        public int IdBenefit { get; set; }
        public string IdProduct { get; set; }
        public string PrdBenefit { get; set; }
        public string Comments { get; set; }
        public DateTime? SubmitDate { get; set; }
    }
}
