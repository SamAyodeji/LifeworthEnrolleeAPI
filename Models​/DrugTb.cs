using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DrugTb
    {
        public int DrugCode { get; set; }
        public string DrugGroup { get; set; }
        public string Drugs { get; set; }
        public string Unit { get; set; }
        public decimal? Unitprice { get; set; }
    }
}
