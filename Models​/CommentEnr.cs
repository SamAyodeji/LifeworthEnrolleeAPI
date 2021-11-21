using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class CommentEnr
    {
        public int Sn { get; set; }
        public string Userid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime? Date { get; set; }
        public bool? Readremark { get; set; }
    }
}
