using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    class TruckCar : Car
    {
        public TruckCar()
        {
            carName = "Teuck";
            modelNumber = 2019;
        }

    }
}
