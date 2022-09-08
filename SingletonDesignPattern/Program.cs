using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //The getInstance method is used also to provide a global point of
            //access to the object and it can be used in the following manner:
            Singleton.getInstance().Method("First Call");


            //Real world Example of Singleton Pattern
            //1. Logger Class
            //2. Configuration Class

        }
    }
}
