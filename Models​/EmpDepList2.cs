using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class EmpDepList2
    {
        public int IdEmployee { get; set; }
        public string EmployeeNo { get; set; }
        public int IdCompany { get; set; }
        public string Surname { get; set; }
        public string FullName { get; set; }
        public DateTime? DateOfBrith { get; set; }
        public int IdProvider { get; set; }
        public string Sex { get; set; }
        public string ImageFileName { get; set; }
        public string CurrentIdPolicy { get; set; }
        public string IdProduct { get; set; }
        public string RelationType { get; set; }
        public string OperationType { get; set; }
        public DateTime? OperationDate { get; set; }
        public string IdProviderFrom { get; set; }
        public int? Sn { get; set; }
    }
}
