using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class Specialty
    {
        public Specialty()
        {
            Provider1 = new HashSet<Provider1>();
        }

        public int IdSpecialty { get; set; }
        public string SpecialtyName { get; set; }
        public string Narration { get; set; }

        public virtual ICollection<Provider1> Provider1 { get; set; }
    }
}
