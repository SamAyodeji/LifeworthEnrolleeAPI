using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuditCoy
    {
        public int Sn { get; set; }
        public string UserName { get; set; }
        public string Task { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? LocalDateTime { get; set; }
    }
}
