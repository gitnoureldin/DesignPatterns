using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    interface ITireLarg
    {
        void drowLargTire();
    }

    class TireLarge : ITireLarg
    {
        public void drowLargTire()
        {
            Console.WriteLine("The Large Tire");
        }
    }
}
