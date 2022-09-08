using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Singleton
    {

        public static Singleton instance;
        
        //The constructor should not be accessible from the outside of the class
        private Singleton() { 
        
        }
        public static Singleton getInstance() {
            //getInstance method ensures that only one instance of the class is created.
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

        public void Method(string str)
        {
            Console.WriteLine("Calling from {0}", str);
        }

    }
}
