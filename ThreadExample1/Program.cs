using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(DoIt);
            Thread thread = new Thread(threadStart);
            thread.Start();
            

            DoIt();
            DoIt();
        }

        private static void DoIt()
        {
            while(true)
           {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
           }
        }
    }
}
