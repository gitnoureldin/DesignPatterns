using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Builder
{
    internal interface IRobotBuilder
    {
        void buildRobotHead();
        void buildRobotArms();
        void buildRobotLegs();
        void buildRobotBody();

        Robot getRobot();
    }
}
