using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TblHrhead
    {
        public int Id { get; set; }
        public int? IdCompany { get; set; }
        public string HeadName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
