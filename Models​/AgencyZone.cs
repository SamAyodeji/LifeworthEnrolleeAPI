using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AgencyZone
    {
        public AgencyZone()
        {
            Agency = new HashSet<Agency>();
        }

        public string IdZone { get; set; }
        public string ZoneName { get; set; }

        public virtual ICollection<Agency> Agency { get; set; }
    }
}
