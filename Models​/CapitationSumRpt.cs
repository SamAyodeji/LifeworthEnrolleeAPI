using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CapitationSumRpt
    {
        public short? IdCompany { get; set; }
        public string CompanyName { get; set; }
        public int Enrollee { get; set; }
        public string MthDesc { get; set; }
        public short? MthCode { get; set; }
        public string Yr { get; set; }
    }
}
