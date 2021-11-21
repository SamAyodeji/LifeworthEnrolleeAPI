using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Helper.Account
{
    public class NewDependantDTO
    {
        public int? IdEmployee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        //public string EmployeeNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string RelationType { get; set; }

        //public string ImageFileName { get; set; }
        public string Sex { get; set; }
    }

}
