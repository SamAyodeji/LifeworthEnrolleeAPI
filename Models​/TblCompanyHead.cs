using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class TblCompanyHead
    {
        public int HeadId { get; set; }
        public int? IdCompany { get; set; }
        public string HeadNameMd { get; set; }
        public string GsmNoMd { get; set; }
        public string EmailMd { get; set; }
        public DateTime? DOBmd { get; set; }
        public string HeadNameHmoc { get; set; }
        public string GsmNoHmoc { get; set; }
        public string EmailHmoc { get; set; }
        public DateTime? DOBhmoc { get; set; }
        public string HeadNameAcc { get; set; }
        public string GsmNoAcc { get; set; }
        public string EmailAcc { get; set; }
        public DateTime? DOBacc { get; set; }
    }
}
