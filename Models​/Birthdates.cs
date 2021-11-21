using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Birthdates
    {
        public string EmployeeNo { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        public string PhoneNo { get; set; }
        public DateTime? DateOfBrith { get; set; }
        public string StatusId { get; set; }
    }
}
