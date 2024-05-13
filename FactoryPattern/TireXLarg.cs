using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    interface ITireXLarg
    {
        void drowXLargTire();
    }

    class TireXLarg : ITireXLarg
    {
        public void drowXLargTire()
        {
            Console.WriteLine("The X-Large Tire");
        }
    }
}
