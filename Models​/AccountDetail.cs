using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AccountDetail
    {
        public int IdAcctDetail { get; set; }
        public int IdAcctMaster { get; set; }
        public string PolicyNo { get; set; }
        public string Narration { get; set; }
        public decimal? Amount { get; set; }
        public string ChqNo { get; set; }
        public string AgentCode { get; set; }
        public decimal? ComsnRate { get; set; }
        public decimal? ComsnPayable { get; set; }
        public int? CompanyId { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public int? PremiumId { get; set; }
        public decimal? DebitAmount { get; set; }
        public decimal? CrNoteAmt { get; set; }
        public decimal? SettledAmt { get; set; }

        public virtual AccountMaster IdAcctMasterNavigation { get; set; }
    }
}
