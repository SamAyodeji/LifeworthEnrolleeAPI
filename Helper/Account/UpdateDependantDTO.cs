using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Helper.Account
{
    public class UpdateDependantDTO
    {
        public string Name { get; set; }
        //public string EmployeeNo { get; set; }
        public DateTime? BirthDate { get; set; }
        //public string RelationType { get; set; }

        //public string ImageFileName { get; set; }
        //public string Sex { get; set; }
        public string Address { get; set; }
    }
}
