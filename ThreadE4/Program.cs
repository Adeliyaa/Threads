using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; // namespace that include the threading 

namespace ThreadE4
{
    class myThread
    {
        Thread thread;
        public myThread(string name, int num)
        {
            thread = new Thread(this.func);
            thread.Name = name;
            thread.Start(num);
        }

        void func(object num)
        {
            for (int i = 0; i < (int)num; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
                Thread.Sleep(0);
            }
            Console.WriteLine(Thread.CurrentThread.Name + " завершился");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myThread t1 = new myThread("Thread 1", 2);
            myThread t2 = new myThread("Thread 2", 3);
            myThread t3 = new myThread("Thread 3", 6);
        }
       
    }
}
