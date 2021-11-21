using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Sickness
    {
        public Sickness()
        {
            EmployeeSickness = new HashSet<EmployeeSickness>();
        }

        public int IdSickness { get; set; }
        public string SicknessName { get; set; }

        public virtual ICollection<EmployeeSickness> EmployeeSickness { get; set; }
    }
}
