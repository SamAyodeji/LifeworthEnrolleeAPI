using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Mailsetup
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public int? Capdays { get; set; }
    }
}
