using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Helper.Account
{
    public class DependantDTO
    {

        public int IdDependant { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdCompany { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string EmployeeNo { get; set; }
       public string image{get; set;}
        public string IsComplete { get; set; }
    }
}
