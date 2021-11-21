using System;
using System.Collections.Generic;

namespace LifeworthAPI.Models​
{
    public partial class GeneralTb
    {
        public string PatientNumber { get; set; }
        public DateTime Date { get; set; }
        public double? Height { get; set; }
        public double? Weight { get; set; }
        public string Genotype { get; set; }
        public string BloodGroup { get; set; }
        public double? Bmi { get; set; }
        public string BmiInference { get; set; }
        public double? BodyTemp { get; set; }
        public string BP { get; set; }
        public double? PulseRate { get; set; }
        public string Position { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
