using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadsE3
{
    class BankAcct
    {
        private Object acctLock = new object();
        double Balance { set; get; }

        public BankAcct(double bal)
        {
            Balance = bal;
        }

        public double Withdraw(double amt)
        {
            if((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;
            }
            lock (acctLock)
            {
                if(Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} left in Account", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";
            for(int i=0; i<15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWithdraw));
                //the constructor for the Thread class requires a ThreadStart 
                //delegate that represents the method to be executed on the thread.
                t.Name = i.ToString();
                threads[i] = t;
            }

            for(int i=0; i<15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
                threads[i].Start();
                Console.WriteLine("Thread {0} Alive : {1}", threads[i].Name, threads[i].IsAlive);
            }

            Console.WriteLine("Current Priority : {0}", Thread.CurrentThread.Priority);

            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);


            Console.ReadLine();
        }
    }
}
