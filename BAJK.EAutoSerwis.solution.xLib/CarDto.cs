using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class CarDto
    {
        public int year { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int speed { get; set; }
        public DateTime lastCheckUp { get; set; }
    }
}
