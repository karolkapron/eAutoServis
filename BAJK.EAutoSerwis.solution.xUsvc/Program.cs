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

            foreach (Car car in CarLot.FindExpiredCheckUp())
            {

                Console.WriteLine("Car to do check on is {0} {1} from {2} last check on {3}", car.Brand, car.Model, car.Year, car.LastCheckUp);
            }
            Console.ReadLine();
        }
    }
}
