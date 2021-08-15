using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Entities
{
    public class Car:Vehicle
    {
        public string CarName { get; set; }//Kimlik
        public int Wheel { get; set; }
        public Boolean Headlight { get; set; }
    }
}
