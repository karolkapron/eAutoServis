using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BAJK.EAutoSerwis.solution.xLib;

namespace BAJK.EAutoSerwis.solution.xLib
{

    public interface ICarLot
    {
        Car[] FindExpiredCheckUp();
        Car[] FindAllTheSameBrands(string name);
        void AddNewCar(Car newCar);
    }
}