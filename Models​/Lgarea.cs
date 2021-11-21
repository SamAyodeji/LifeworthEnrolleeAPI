using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Lgarea
    {
        public Lgarea()
        {
            Employee5 = new HashSet<Employee5>();
        }

        public int Id { get; set; }
        public string IdLga { get; set; }
        public string IdState { get; set; }
        public string LgArea1 { get; set; }

        public virtual ICollection<Employee5> Employee5 { get; set; }
    }
}
