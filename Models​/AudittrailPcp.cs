using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AudittrailPcp
    {
        public int Sn { get; set; }
        public string Username { get; set; }
        public string Task { get; set; }
        public DateTime? Ltime { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
