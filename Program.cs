using dsignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Car car = null;

            Console.WriteLine("select Your Car type,\n s = Sedan,\n U = SUV,\n T= Truck,\n");
            string type = Console.ReadLine();

            AbstractFactory order = new CarFactory();

            car = order.getYourCar(type);
            runCommand(car);
            order.getYourTire(type);


            Console.ReadKey(true);
        }

        static void runCommand (Car car)
        {
            car.RunCar();
            car.ShowCar();

        }

    }

}
