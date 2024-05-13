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
            //class1 c = class1.getIntance();       // we dont write a new class but refare the the methode getInctance and it returns new class every time
            //c.print("Hello u class1!");

            Parallel.Invoke(    // .Invok to invok the methodes inside
                () => method1(),
                () => method2()

                );

            //class1 c2 = class1.getIntance();
            //c.print("new msg class2");

            //class1.son sn = new class1.son();
            //sn.print("son class");


           // Console.ReadKey(true);

                             //////////////////////////////////////////////////////////////////////////////////////
                             
             ///////////
            // the old way to use factory desig pattern by using Singelton.Factory; 
           /////////

           // Car car = new SedanCar();
            //car.RunCar();

            Car car = null;


            Console.WriteLine("select Your Car type,\n s = Sedan,\n U = SUV,\n T= Truck,\n");
            string CarType = Console.ReadLine();

            switch (CarType)
            {
                case "s":
                       car = new SedanCar();
                break ;
                 
                case "u":
                    car = new SuvCar();

                break ;
                 
                case "t":
                    car = new TruckCar();

                break ;

            }

            runCommand(car);

            Console.ReadKey(true);

        }

        static void runCommand (Car car)
        {
            car.RunCar();
            car.ShowCar();
        }


                           /// /////////////////////////////////////////////////////////////////////////////////////////////
                                   
      
        
        public static void method1()
        {
            class1 c = class1.getIntance();       // we dont write a new class but refare the the methode getInctance and it returns new class every time
            c.print("Hello u class1!");

        }
        public static void method2()
        {
            class1 c2 = class1.getIntance();
            c2.print("new msg class2");
        }
       
        


    }

}
