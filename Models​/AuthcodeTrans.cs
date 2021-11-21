using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuthcodeTrans
    {
        public string Authcode { get; set; }
        public string AuthBy { get; set; }
        public DateTime? Date { get; set; }
        public string Employeeid { get; set; }
        public string UserId { get; set; }
        public int? IdProvider { get; set; }
        public string Claim { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string Provtype { get; set; }
    }
}
