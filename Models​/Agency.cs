using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Agency
    {
        public string AgencyId { get; set; }
        public string IdZone { get; set; }
        public string AgencyName { get; set; }
        public string Management { get; set; }
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankGlactno { get; set; }
        public string AgencyCode { get; set; }
        public decimal? FyTarget { get; set; }
        public decimal? RnTarget { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string StateId { get; set; }

        public virtual AgencyZone IdZoneNavigation { get; set; }
    }
}
