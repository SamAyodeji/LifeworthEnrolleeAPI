using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Notification6
    {
        public int Sn { get; set; }
        public string Notification { get; set; }
        public DateTime? Insertdate { get; set; }
        public string Userid { get; set; }
        public bool? Status { get; set; }
    }
}
