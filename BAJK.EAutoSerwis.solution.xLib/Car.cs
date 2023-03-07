using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class Car
    {
        private int year;
        private String make;
        private int speed;
        private DateTime lastCheckUp;

        public Car(int year, string make, int speed, DateTime lastCheckUp)
        {
            this.Year = year;
            this.Make = make;
            this.Speed = speed;
            this.lastCheckUp = lastCheckUp;
        }

        public int Year { get => year; set => year = value; }
        public string Make { get => make; set => make = value; }
        public int Speed { get => speed; set => speed = value; }
        public DateTime LastCheckUp { get => lastCheckUp;}

        public void updateCheckUp()
        {
            this.lastCheckUp = DateTime.Now;
        }
        public bool IsCheckUpExpired()
        {
            return YearsDiff.Diff(this.lastCheckUp, DateTime.Now) > 1;
        }
        
    }
    public static class YearsDiff
    {
        public static double Diff(DateTime start, DateTime end)
        {
            TimeSpan span = end - start;
            return span.TotalDays / 365.25;
        }

    }
    public interface ICarLot
    {
        Car[] FindExpiredCheckUp();
    }

    public class CarLot : ICarLot
    {
        private readonly Car[] cars = new Car[]
        {
            new Car(2009, "VW", 0, DateTime.Now),
            new Car(2019, "Citroen", 0, new DateTime(2019, 12, 2)),
            new Car(2013, "Opel", 0, new DateTime(2023, 2, 4)),
            new Car(2021, "Reanult", 0, new DateTime(2021, 9, 21))
        };

        public Car[] FindExpiredCheckUp()
        {
            IList<Car> foundCars = cars.Where(c => c.IsCheckUpExpired()).ToList();

            return foundCars.ToArray();
        }
    }
}
