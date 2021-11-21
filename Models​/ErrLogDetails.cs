using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ErrLogDetails
    {
        public int IdErrLogDtl { get; set; }
        public int? IdErrLogMst { get; set; }
        public int? LnNo { get; set; }
        public string Narration { get; set; }
    }
}
