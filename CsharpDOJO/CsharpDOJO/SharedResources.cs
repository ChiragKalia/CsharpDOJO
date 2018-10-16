

using System;
using System.Threading;

namespace CsharpDOJO.MultiThreading
{
    class SharedResources
    {
        private static bool isCompleted;
        private static readonly object lockCompleted = new object();
        static int Main(string[] args)
        {
            Thread thread = new Thread(HelloWorld);
            //Worker Thread
            thread.Start();
            //Main Thread
            HelloWorld();
            return 0;
        }

        private static void HelloWorld()
        {
            lock (lockCompleted)
            {
                if(!isCompleted)
                {
                    isCompleted = true;
                    Console.WriteLine("Hello World should run only once");
                }
            }
        }
    }
}
