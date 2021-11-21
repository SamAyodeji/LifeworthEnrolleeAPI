using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuditP
    {
        public int Sn { get; set; }
        public string UserName { get; set; }
        public string Task { get; set; }
        public string DateTime { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? LocalDateTime { get; set; }
    }
}
