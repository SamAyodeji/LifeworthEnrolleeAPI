using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class VoucherNo
    {
        public int IdVoucher { get; set; }
        public string VoucherNo1 { get; set; }
        public string Title { get; set; }
        public string PostPeriod { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
