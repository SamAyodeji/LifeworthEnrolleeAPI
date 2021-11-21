using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CrNoteMaster
    {
        public int IdCrNoteMaster { get; set; }
        public int? IdCompany { get; set; }
        public DateTime? ValueDate { get; set; }
        public string StatusId { get; set; }
        public string CapturedBy { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? TransDate { get; set; }
        public decimal? CrNoteAmt { get; set; }
        public string Narration { get; set; }
        public string Notes { get; set; }
    }
}
