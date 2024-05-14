using dsignPatterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dsignPatterns.Builder;
using System.Threading;

namespace singelton
{
    class Program
    {
        static void Main(string[] args)
        {
            IRobotBuilder oldRobotBuilder = new oldRobotBuilder();      // the old way that goes to the class and call the methodes one by one 
            RobotBuilder robotBuilder = new RobotBuilder(oldRobotBuilder); // the new way 

            robotBuilder.makeRobot();

            Robot robot = robotBuilder.getRobot();

            if (robot != null)
            {
                Console.Write(" Head: ");
                Thread.Sleep(1000);         // 1000 milliseconds delay (1 second) to give some motion :) 

                Console.WriteLine(robot.getRobotHead());

                Console.Write("\n Arms: ");
                Thread.Sleep(1000);
                Console.WriteLine(robot.getRobotArms());

                Console.Write("\n Body: ");
                Thread.Sleep(1000);
                Console.WriteLine(robot.getRobotBody());

                Console.Write("\n Legs: ");
                Thread.Sleep(1000);
                Console.WriteLine(robot.getRobotLegs());
                Thread.Sleep(1000);

            }
            Console.WriteLine("\n your robot is completed!");
            
            Console.ReadKey(true);
        }

    }

}
