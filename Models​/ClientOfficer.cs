using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ClientOfficer
    {
        public string OfficerCode { get; set; }
        public string SurName { get; set; }
        public string OtherNames { get; set; }
        public string Department { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public string UserId { get; set; }
    }
}
