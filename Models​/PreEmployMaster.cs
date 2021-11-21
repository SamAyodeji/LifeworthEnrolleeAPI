using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class PreEmployMaster
    {
        public PreEmployMaster()
        {
            PreEmployDetail = new HashSet<PreEmployDetail>();
        }

        public int IdPreEmpMaster { get; set; }
        public int? IdCompany { get; set; }
        public decimal? DebitAmount { get; set; }
        public string Narration { get; set; }
        public string InvNo { get; set; }
        public DateTime? ValueDate { get; set; }
        public DateTime? TransDate { get; set; }
        public string CapturedBy { get; set; }
        public string Status { get; set; }
        public string ApprovedBy { get; set; }
        public int? NoOfEmp { get; set; }
        public string Notes { get; set; }
        public string TransType { get; set; }

        public virtual ICollection<PreEmployDetail> PreEmployDetail { get; set; }
    }
}
