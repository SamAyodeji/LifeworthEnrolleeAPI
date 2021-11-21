using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class DoctorInfoTb
    {
        public int IdDoctor { get; set; }
        public int? IdProvider { get; set; }
        public string DoctorName { get; set; }
        public string AreaOfspecialisation { get; set; }
        public string Institutionattended { get; set; }
        public int? YearofGraduation { get; set; }
        public string Position { get; set; }
        public string Area { get; set; }
    }
}
