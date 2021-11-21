using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CrNoteDetail
    {
        public int IdCrNoteDetail { get; set; }
        public int? IdCrNoteMaster { get; set; }
        public int? IdCompany { get; set; }
        public string PolicyNo { get; set; }
        public int? NoOfEmp { get; set; }
        public decimal? CrNoteAmt { get; set; }
        public string Narration { get; set; }
        public int? PremiumId { get; set; }
    }
}
