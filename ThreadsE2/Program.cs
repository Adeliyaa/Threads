using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsE2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Print);
            t.Start();
            int num = 1;
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(num);
                Thread.Sleep(1000);
                num++;
            }
            Console.WriteLine("Threads Ends");
        }

        static void Print()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(123);
                Thread.Sleep(2000);
                
            }

        }

    }
}
