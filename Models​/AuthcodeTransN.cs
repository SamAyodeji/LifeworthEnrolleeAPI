using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuthcodeTransN
    {
        public string Authcode { get; set; }
        public string AuthBy { get; set; }
        public DateTime? Date { get; set; }
        public string Employeeid { get; set; }
        public string UserId { get; set; }
        public string IdProvider { get; set; }
        public string Claim { get; set; }
    }
}
