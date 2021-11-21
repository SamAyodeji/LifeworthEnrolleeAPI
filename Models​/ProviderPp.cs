using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ProviderPp
    {
        public int IdProvider { get; set; }
        public string ProviderName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string IdState { get; set; }
        public string IdLga { get; set; }
        public string PhoneNumbers { get; set; }
        public string Email { get; set; }
        public short? IdDoctor { get; set; }
        public string Email2 { get; set; }
        public string Bandtype { get; set; }
    }
}
