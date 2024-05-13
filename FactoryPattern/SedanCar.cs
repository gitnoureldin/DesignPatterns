using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsignPatterns.FactoryPattern
{
    internal class SedanCar : Car    // inhirent from the Super class
    {
        public SedanCar() 
        {
            carName = "BMW";
            modelNumber = 2020;
            
        }
    }
}
