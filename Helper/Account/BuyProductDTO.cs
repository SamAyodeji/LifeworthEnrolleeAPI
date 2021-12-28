using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeworthAPI.Helper.Account
{
    public class BuyProductDTO
    {
        public string IdProduct { get; set; }

        public string Name { get; set; }

        public string IndividualPrice { get; set; }

        public string FamilyPrice { get; set; }

        public string Benefits { get; set; }
    }
}
