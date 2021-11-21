using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class RptNhisdetails
    {
        public string Hcpcode { get; set; }
        public string FamilyCode { get; set; }
        public string PstatusId { get; set; }
        public string Pstatusname { get; set; }
        public string Psurname { get; set; }
        public string Pothername { get; set; }
        public string Psex { get; set; }
        public DateTime? Pdob { get; set; }
        public string Plcode { get; set; }
        public string Indcode1 { get; set; }
        public int Indcode { get; set; }
        public int? Qtr { get; set; }
        public int? Year { get; set; }
    }
}
