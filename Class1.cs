using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singelton
{
    sealed class class1   // seald class dont allow inharitet like       public class son : class1 { }
    { 
        // to know how many instance is made from this variable 
        private static int counter;
        //private static class1 instance = null;
        //private static readonly class1 instance = new class1(); // for the eager loading we made it as evry time it loads it takes new class and put in that instace variable and its readonly to reduce space
        private static readonly Lazy<class1> instance = new Lazy<class1>(()=> new class1());  // to convert the eager laoding above to lazy we just added the keyword 'Lazy' + the grnaric from the class <class1> + lamda exoression ()=> new class1() that fat arrow like the keyword return   and not need to conver amd delewte amd lock the obj to convert it 
                                                                                                                                                                                                                                                      
        private static readonly object obj = new object();

        private class1()
        {
            counter += 1;

            Console.WriteLine(" instatce Number " + counter.ToString());
        }

        public static class1 getIntance()   // static becouse we call it the same evrz time in a const way
        {
            //return new class1();
            //if (instance == null)             // we addded this if becouse look object make heave reesouces usage and its not recomended but when u have to then put in if() {} 
            //{
            //    lock (obj)
            //    {
            //        if (instance == null)
            //        {
            //            instance = new class1();
            //        }
            //    }
            //}
          //return instance;                 // cant work with the Lazy Loading + genaric class so we added .Value 
          return instance.Value;
        }
          
        public void print(string msg)
        {
            Console.WriteLine(msg);
        }

        //public class son : class1         // not singelton class so will counted in the counter           and not acsing in sealed class
        //{

        //}
    }

}
