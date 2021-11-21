using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Complains
    {
        public int IdComplain { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime ComplainDate { get; set; }
        public int? IdProvider { get; set; }
        public string IdComplainType { get; set; }
        public string ComplainDetails { get; set; }
        public DateTime? DateReceived { get; set; }
        public string ReceivedBy { get; set; }
        public bool? Treated { get; set; }
        public string ActionTaken { get; set; }
        public string IdComplainEndResult { get; set; }
        public string CallerName { get; set; }
        public int? IdCompany { get; set; }
        public string Complainby { get; set; }
    }
}
