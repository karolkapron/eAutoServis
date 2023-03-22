using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Text.Json;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class MechanicLot : IMechanicLot
    {
        static List<Mechanic> mechanics = new List<Mechanic>
        {
            new Mechanic(Guid.NewGuid(), "Jan", "Kowalski", "Wulkanizacja"),
            new Mechanic(Guid.NewGuid(), "Antoni", "Fajka", "Przeglady"),
            new Mechanic(Guid.NewGuid(), "Karolina", "Koper", "Katalizacja")
        };
        public Mechanic[] GetAllMechanics(){
            return mechanics.ToArray();
        }
        public void AddNewMechanic(MechanicDto newMechanic)
        {
            Mechanic mechanic = new Mechanic(Guid.NewGuid(), newMechanic.Name, newMechanic.Surname, newMechanic.Specialisation);
            mechanics.Add(mechanic);
        }
    }
}
