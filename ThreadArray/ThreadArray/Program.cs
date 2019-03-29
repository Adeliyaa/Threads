using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadArray
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread[] threadsArray = new Thread[4];
            for (int i=0; i<4; i++)
            {
                int localNum = i;
                threadsArray[i] = new Thread(() => k(localNum));
            }

            for(int i=0; i<4; i++)
            {
                threadsArray[i].Start();
                Thread.Sleep(1000);
            } 

            for(int i=0; i<4; i++)
            {
                threadsArray[i].Join();
            }

            void k(int i)
            {
              
                Console.WriteLine(i);
               

            }
        }

        
    }
}
