using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Cheque
    {
        public int IdPay { get; set; }
        public string Pay { get; set; }
        public DateTime? Date { get; set; }
        public string AmountinWord { get; set; }
        public decimal? Amount { get; set; }
        public string PayCode { get; set; }
    }
}
