using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Agents
    {
        public int IdAgent { get; set; }
        public string AgentCode { get; set; }
        public string AgentName { get; set; }
        public string Address01 { get; set; }
        public string Address02 { get; set; }
        public string IdState { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public decimal? AgreedCommsn { get; set; }
        public DateTime? DateEmployed { get; set; }
        public string Comments { get; set; }
        public string AgentType { get; set; }
        public string GlcomsnAcctNo { get; set; }
        public string Sex { get; set; }
        public string Mstatus { get; set; }
        public DateTime? Dob { get; set; }
        public string Kin { get; set; }
        public string Kinadd { get; set; }
        public string Kinphone { get; set; }
        public string Status { get; set; }
        public string IdAgenttype { get; set; }
    }
}
