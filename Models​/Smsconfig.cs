using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Smsconfig
    {
        public int Sn { get; set; }
        public string Api { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
    }
}
