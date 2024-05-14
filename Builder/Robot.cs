using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Builder
{
    internal class Robot : IRobotPlan
    {
        private string RobotArms;
        private string RobotBody;
        private string RobotHead;
        private string RobotLegs;

        public void setRobotArms(string Arms)
        {
            RobotArms = Arms;
        }

        public void setRobotBody(string Body)
        {
            RobotBody = Body;
        }

        public void setRobotHead(string Head)
        {
            RobotHead = Head;
        }

        public void setRobotLegs(string Legs)
        {
            RobotLegs = Legs;
        }

        public string getRobotArms()
        {
           return RobotArms;
        }

        public string getRobotBody()
        {
            return RobotBody;
        }

        public string getRobotHead()
        {
            return RobotHead;
        }

        public string getRobotLegs()
        {
            return RobotLegs;
        }
    }
}
