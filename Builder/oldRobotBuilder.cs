using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Builder
{

    /// <summary>
    /// the old way to implemnt the class without using the builder Design pattern
    /// </summary>
    internal class oldRobotBuilder : IRobotBuilder
    {
        private Robot robot;
        public oldRobotBuilder()  // constractor
        {
          robot = new Robot();
        }



        public void buildRobotArms()
        {
            robot.setRobotArms("Arms are ready");
        }

        public void buildRobotBody()
        {
            robot.setRobotBody("Body is ready");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("Heead is ready");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Legs are ready");
        }
    }
}
