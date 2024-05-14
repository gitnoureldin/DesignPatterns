using dsignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using dsignPatterns.Builder;
using System.Threading;
using System.Runtime.InteropServices;
using dsignPatterns.Prototype;
using static dsignPatterns.Prototype.Robot;

namespace singelton
{
    class Program
    {


        static void Main(string[] args)
        {
            Robot robot1 = new Robot();
            robot1.Age = 42;
            robot1.BirthDate = Convert.ToDateTime("1977-01-01");
            robot1.Name = "John Doe";
            robot1.idInfo = new IdInfno(606);

            Robot robot2 = robot1.ShallowCopy();
            Robot robot3 = robot1.DeepCopy();
            Robot robot4 = robot1;

            Console.WriteLine("Original Values of robot1, robot2, robot3, robot4");
            Console.WriteLine("robot1 instance values: ");
            DisplayValues(robot1);
            Console.WriteLine("robot2 instance values: ");
            DisplayValues(robot2);
            Console.WriteLine("robot3 instance values: ");
            DisplayValues(robot3);
            Console.WriteLine("robot4 instance values: ");
            DisplayValues(robot4);

            robot1.Age = 32;
            robot1.BirthDate = Convert.ToDateTime("1900-02-02");
            robot1.Name = "New Name";
            robot1.idInfo.IdNumber = 707;

            Console.WriteLine("\n Values of robot1, robot2, robot3, robot4 AFTER CHANGES OF Robot1");
            Console.WriteLine("robot1 instance values: ");
            DisplayValues(robot1);
            Console.WriteLine("robot2 instance values: ");
            DisplayValues(robot2);
            Console.WriteLine("robot3 instance values: ");
            DisplayValues(robot3);
            Console.WriteLine("robot4 instance values: ");
            DisplayValues(robot4);


            Console.ReadKey(true);
        }

        public static void DisplayValues(dsignPatterns.Prototype.Robot robot)
        {
            Console.WriteLine("  Name {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}  ",
                robot.Name, robot.Age, robot.BirthDate);
            Console.WriteLine(" ID# {0:d}", robot.idInfo.IdNumber);
        }

    }

}
