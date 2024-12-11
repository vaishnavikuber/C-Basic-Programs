using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Timers;

namespace Programs
{
    internal class ExecutionTime
    {

        public static void executionTime()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("Hello");
            Console.WriteLine("Here is the time!!!!");
            watch.Stop();
            TimeSpan span = watch.Elapsed;

            Console.WriteLine("Execution time is : "+span.TotalSeconds+" s");
        }

    }
}
