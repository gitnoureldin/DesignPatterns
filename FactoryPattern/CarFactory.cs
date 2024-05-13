using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    class CarFactory
    {

        public Car getYourCar(string carType)
        {
            switch (carType)
            {
                case "s":
                    return new SedanCar();

                case "u":
                    return new SuvCar();


                case "t":
                   return new TruckCar();

                default:
                    throw new ArgumentException("Invalid car type specified"); // to make sure all pathes return the rigth value

            }
        }

    }
}
