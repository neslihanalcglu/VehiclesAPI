using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Entities
{
    public class Color
    {
        public int ColorID { get; set; }
        public string ColorName { get; set; }

        public List<Vehicle> Vehicles { get; set; }
    }
}
