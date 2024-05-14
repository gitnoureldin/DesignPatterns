using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Builder
{
    internal class RobotBuilder
    {
        private IRobotBuilder robotBuilder;

        public RobotBuilder(IRobotBuilder _robotBuilder)  // make a constractor sending our RobotBuilder in it 
        {
            this.robotBuilder = _robotBuilder;             // so here im encapulating the methodes that are on out oldRobtBuilder
        }

        public Robot getRobot()
        {
           return robotBuilder.getRobot();
        }

        public void makeRobot()                 // here i encapsulated build the all object so and its ready to take from the return robotBuilder.getRobot
        {
            robotBuilder.buildRobotArms();
            robotBuilder.buildRobotBody();
            robotBuilder.buildRobotHead();
            robotBuilder.buildRobotLegs();
        }
    }
}
