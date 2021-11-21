using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Reimburse
    {
        public int Formno { get; set; }
        public string Coyname { get; set; }
        public string EnrolleeId { get; set; }
        public string Ename { get; set; }
        public string Pp { get; set; }
        public string Reason { get; set; }
        public string Hosp { get; set; }
        public DateTime? Vdate { get; set; }
        public DateTime? Ddate { get; set; }
        public string Diag { get; set; }
        public string Ecase { get; set; }
        public string Qinform { get; set; }
        public string Inform { get; set; }
        public DateTime? Ndate { get; set; }
    }
}
