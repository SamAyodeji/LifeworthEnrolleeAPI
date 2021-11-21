using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class ClaimsNotes
    {
        public int Sn { get; set; }
        public string EmployeeNo { get; set; }
        public string Notes { get; set; }
        public string NoteHistory { get; set; }
        public string UserId { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
