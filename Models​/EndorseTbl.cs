using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class EndorseTbl
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int? Groupno { get; set; }
        public decimal? Premium { get; set; }
        public int? IdCompany { get; set; }
    }
}
