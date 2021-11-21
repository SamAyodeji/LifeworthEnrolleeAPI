using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class EmployeeSickness
    {
        public int IdEmployeeSickness { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdSickness { get; set; }

        public virtual Sickness IdSicknessNavigation { get; set; }
    }
}
