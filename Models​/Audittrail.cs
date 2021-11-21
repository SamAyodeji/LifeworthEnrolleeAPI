using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Audittrail
    {
        public int Sn { get; set; }
        public string Username { get; set; }
        public string Task { get; set; }
        public string Ltime { get; set; }
        public DateTime? Ldate { get; set; }
    }
}
