using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AccountMaster
    {
        public AccountMaster()
        {
            AccountDetail = new HashSet<AccountDetail>();
        }

        public int IdAcctMaster { get; set; }
        public int IdCompany { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public decimal? Balance { get; set; }
        public decimal? NewBalance { get; set; }
        public decimal? Amount { get; set; }
        public string ChqInvNo { get; set; }
        public string Narration { get; set; }
        public bool? PayManual { get; set; }
        public decimal? PremiumAmt { get; set; }
        public decimal? PreEmployAmt { get; set; }

        public virtual ICollection<AccountDetail> AccountDetail { get; set; }
    }
}
