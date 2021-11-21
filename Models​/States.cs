using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class States
    {
        public States()
        {
            Employee5 = new HashSet<Employee5>();
        }

        public string Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Employee5> Employee5 { get; set; }
    }
}
