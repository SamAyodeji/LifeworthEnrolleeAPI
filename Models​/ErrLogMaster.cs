using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ErrLogMaster
    {
        public int IdErrLogMst { get; set; }
        public DateTime? TransDate { get; set; }
        public string Narration { get; set; }
        public string ProcessedBy { get; set; }
        public int? ErrCount { get; set; }
        public bool? Klose { get; set; }
    }
}
