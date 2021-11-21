using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AuthorizerTb
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public bool? Status { get; set; }
    }
}
