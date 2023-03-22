using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public interface IMechanicLot
    {
        Mechanic[] GetAllMechanics();
        void AddNewMechanic(MechanicDto newMechanic);
    }
}
