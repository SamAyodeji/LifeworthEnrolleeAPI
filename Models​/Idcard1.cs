using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Idcard1
    {
        public int IdIdcard { get; set; }
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Product { get; set; }
        public string ExpDate { get; set; }
        public byte[] Photo { get; set; }
    }
}
