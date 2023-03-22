using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class CarLot : ICarLot
    {
        private static List<Car> cars = new List<Car> { };

        static CarLot() {
            // Loading data from JSON
            try
            {
                string json = File.ReadAllText(@"./data.json");
                CarDto[] loadedCars = JsonSerializer.Deserialize<CarDto[]>(json);
                cars = loadedCars.Select(carDto => new Car(carDto.year, carDto.brand, carDto.model, carDto.speed, carDto.lastCheckUp)).ToList();
            }
            catch (Exception e){ 
                Console.Write(e.ToString());
            
            }
        }

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
        public void AddNewCar(CarDto newCar)
        {
            Car car = new Car(newCar.year, newCar.brand, newCar.model, newCar.speed, newCar.lastCheckUp);
            cars.Add(car);
        }
    }
}
