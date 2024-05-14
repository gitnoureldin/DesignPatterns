using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Builder
{
    internal interface IRobotPlan
    {
        void setRobotHead(string Head);
        void setRobotArms(string Arms);
        void setRobotLegs(string Legs);
        void setRobotBody(string Body);
    }
}
