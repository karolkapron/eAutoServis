using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{
    public class Car
    {
        private int year;
        private string brand;
        private string model;
        private int speed;
        private DateTime lastCheckUp;

        public Car(int year, string model, DateTime lastCheckUp)
        {
            this.Year = year;
            this.model = model;
            this.Brand = brand;
            this.Speed = 0;
            this.lastCheckUp = lastCheckUp;
        }
        public Car(int year, string brand, string model, int speed, DateTime lastCheckUp)
        {
            this.Year = year;
            this.model = model;
            this.Brand = brand;
            this.Speed = speed;
            this.lastCheckUp = lastCheckUp;
        }

        public int Year { get => year; set => year = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => Model = value; }
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
        public override string ToString()
        {
            return this.brand;
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
}
