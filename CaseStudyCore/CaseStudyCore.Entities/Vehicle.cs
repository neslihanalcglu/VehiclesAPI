using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Entities
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }

        public int ColorID { get; set; }
        public Color Color { get; set; }
    }
}
