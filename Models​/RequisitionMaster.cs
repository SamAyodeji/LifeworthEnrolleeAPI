using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class RequisitionMaster
    {
        public int IdReqMaster { get; set; }
        public DateTime ValueDate { get; set; }
        public string Narration { get; set; }
        public string ProcessedBy { get; set; }
        public string StatusId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string ProcessCode { get; set; }
        public string Notes { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
