using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CsharpDOJO.MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(WriteUsingANewThread);
            //Worker Thread
            thread.Start();
            //Main Thread
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(String.Format("Main {0} ", i));
            }
            //The results will never be the same 
        }

        private static void WriteUsingANewThread()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(String.Format("Work {0} ", i)); // Worker Thread
            }
        }
    }
}
