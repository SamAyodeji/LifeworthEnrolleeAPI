using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class BankTb
    {
        public string BankCode { get; set; }
        public string BankName { get; set; }
        public string BankAddress { get; set; }
        public string BankCity { get; set; }
        public string BankState { get; set; }
        public string BankCountry { get; set; }
        public string BankPhone { get; set; }
        public string BankEMail { get; set; }
        public string BankFax { get; set; }
        public string BranchCode { get; set; }
        public string BranchDescription { get; set; }
    }
}
