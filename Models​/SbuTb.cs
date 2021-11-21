using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class SbuTb
    {
        public int Sn { get; set; }
        public int? IdCompany { get; set; }
        public string Sbu { get; set; }
        public string Description { get; set; }
        public string StatusId { get; set; }
        public DateTime? Datemove { get; set; }
        public string UserMove { get; set; }
    }
}
