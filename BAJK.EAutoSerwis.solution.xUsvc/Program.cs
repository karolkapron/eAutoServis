using BAJK.EAutoSerwis.solution.xLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJK.EAutoSerwis.solution.xUsvc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarLot CarLot = new CarLot() as ICarLot;
            IMechanicLot MechanicLot = new MechanicLot() as IMechanicLot;

            foreach (Car car in CarLot.FindExpiredCheckUp())
            {

              Console.WriteLine("Car to do check on is {0} {1} from {2} last check on {3}", car.Brand, car.Model, car.Year, car.LastCheckUp);
              
            }

            foreach(Car car in CarLot.FindAllTheSameBrands("Opel"))
            {
                Console.WriteLine("Car {0} {1} {2}", car.Brand, car.Model, car.Year);
            }
            foreach (Mechanic mechanic in MechanicLot.GetAllMechanics())
            {
                Console.WriteLine("Mechanic {0} {1} {2}", mechanic.Name, mechanic.Id, mechanic.Surname);
            }

            Console.ReadLine();
        }
    }
}
