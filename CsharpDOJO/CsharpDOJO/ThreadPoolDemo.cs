using System;
using System.Threading;

namespace CsharpDOJO.MultiThreading
{
    public class ThreadPoolDemo
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Chirag Kalia";
            employee.CompanyName = "Landis Gyr";
            ThreadPool.QueueUserWorkItem(new WaitCallback(DisplayEmployeeInfo), employee);
            var processorCount = Environment.ProcessorCount; // If there are 4 processors in your computer for instance then the number of max threads should be 8
            ThreadPool.SetMaxThreads(processorCount * 2, processorCount * 2);
            // We can also set this another way by getting the min number of threads using ThreadPool.SetMinThreads
            // And then multiply that by two
            Console.ReadKey();    
        }

        private static void DisplayEmployeeInfo(object employee)
        {
            Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
            Employee emp = employee as Employee;
            Console.WriteLine("Person name is {0} and company name is {1}", emp.Name, emp.CompanyName);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string CompanyName { get; set; }
    }
}
