using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class CarLot : ICarLot
    {
        private List<Car> cars = new List<Car>
        {
            new Car(2009, "VW", "Passat", 0, DateTime.Now),
            new Car(2019, "Citroen", "Cactus", 0, new DateTime(2019, 12, 2)),
            new Car(2013, "Opel", "Astra", 0, new DateTime(2023, 2, 4)),
            new Car(2015, "Opel", "Zafira", 0, new DateTime(2023, 3, 4)),
            new Car(2021, "Reanult", "Clio", 0, new DateTime(2021, 9, 21))
        };

        public Car[] FindExpiredCheckUp()
        {
            IList<Car> foundCars = cars.Where(c => c.IsCheckUpExpired()).ToList();

            return foundCars.ToArray();
        }
        public Car[] FindAllTheSameBrands(string name)
        {
            IList <Car> foundCars = cars.Where(c => c.Brand == name).ToList();
            return foundCars.ToArray();
        }
        public void AddNewCar(Car newCar)
        {
            //cars = cars.Concat(new Car[] { newCar }).ToArray();
            cars.Add(newCar);
            //Console.Write(cars.Length);
        }
    }
}
