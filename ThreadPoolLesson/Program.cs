using System;
using System.Threading;

namespace ThreadPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 1
            //ThreadPool.GetAvailableThreads(out int threads, out int prts);
            //Console.WriteLine(threads);
            //for (int i = 0; i <= 60; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(ProccesNumbers);
            //}
            //Console.ReadLine();

            Timer timer = new Timer(ProccesNumbers, null, TimeSpan.FromSeconds(3), TimeSpan.FromSeconds(5));
            Console.ReadLine();
        }

        static void ProccesNumbers(object state)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            ///1
            //var currentthread = Thread.CurrentThread;

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"[{currentthread.ManagedThreadId}] - {i}");
            //    Thread.Sleep(200);
            //}

            //Console.WriteLine($"[{currentthread.ManagedThreadId}] - закончил считать");
        }
    }
}
