
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Print1);

            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(0);
                Thread.Sleep(0);
            }

            Console.ReadLine();

        }

        static void Print1()
        {
            for(int i=0; i<10; i++)
            {
                Console.Write(1);
                Thread.Sleep(0);
            }
        }
    }

   

}
