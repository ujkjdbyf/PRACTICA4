using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static public long fnc(int n)
        {
            long a = 0;
            int b = 3;
            int c = 3;
            long s = 0;

            for (int j = 1; j <= n; j++)
            {
                a = 0;
                for (long i = 1; i <= 100000000; i++)
                    a += b * 2 + c - j;
                s += a;
            }
            Console.WriteLine($"f({n}) = {s}");
            return s;
        }
        static void Main (string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); //запуск
            long s = fnc(2);
            stopwatch.Stop(); //остановить

            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime = " + elapsedTime);
            return;
        }
    }
}