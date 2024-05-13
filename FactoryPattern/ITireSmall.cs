using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    interface ITireSmall
    {
        void drowSmallTire();
    }

    class TireSmall : ITireSmall
    {
        public void drowSmallTire() 
        {
            Console.WriteLine("The Small Tire");
        }
    }
}
