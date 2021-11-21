using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class FirstCapRun
    {
        public int IdFirstCapRun { get; set; }
        public int? IdCompany { get; set; }
        public int? IdProvider { get; set; }
        public decimal? AmtBro { get; set; }
        public decimal? AmtSil { get; set; }
        public decimal? AmtGol { get; set; }
        public decimal? AmtAll { get; set; }
        public string Userid { get; set; }
    }
}
