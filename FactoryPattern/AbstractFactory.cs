using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    interface AbstractFactory
    {
        void getYourTire(string tireType);

        Car getYourCar(string type);
    }
}
