using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    class CarFactory : AbstractFactory
    {

        public void getYourTire(string tireType)
        {
            switch (tireType)
            {
                case "s":
                    new TireSmall().drowSmallTire();
                    break;

                case "u":
                    new TireLarge().drowLargTire();
                    break;


                default :
                  new TireXLarg().drowXLargTire();
                    break;

                //default:
                //    throw new ArgumentException("Invalid car tire specified"); // to make sure all pathes return the rigth value

            }
        }

        public Car getYourCar(string type)
        {
            switch (type)
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
