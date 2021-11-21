using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class AgentType
    {
        public string IdAgentType { get; set; }
        public string Description { get; set; }
        public decimal? CommsnRate { get; set; }
        public decimal? IndRate { get; set; }
        public decimal? CorpRate { get; set; }
        public bool? ChargeVat { get; set; }
    }
}
