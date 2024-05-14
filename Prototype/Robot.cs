using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.Prototype
{
    internal class Robot
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfno idInfo;

        /// </summary>
        // here the types of the clone ( shallow clone, deep clone)
        /// shallow clone takes copy from the class but leaves the refrence values as it is
        ///  so when u change the value of the superclass the value will be cahnged but the refrences types will not be changed
        /// </summary>

        public Robot ShallowCopy()
        {
            return (Robot)this.MemberwiseClone();    // this will colne the Person class but makes a shallow copy  and will take the refrence values only
        }

        public Robot DeepCopy()
        {
            Robot robot = (Robot)this.MemberwiseClone();
            robot.idInfo = new IdInfno(this.idInfo.IdNumber);
            robot.Name = string .Copy(Name);

            return robot;
        }

        public class IdInfno
        {
            public int IdNumber;

            public IdInfno(int idNumber)
            {
                this.IdNumber = idNumber;
            }
        }


    }
}
