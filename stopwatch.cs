using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programming_problems
{
    internal class StopWatch
    {
        public static void displaystopwatchtime()
        {
            Console.WriteLine("Press any key to start the time");
            Console.ReadKey();
            Console.WriteLine(" ");
            DateTime starttime = DateTime.Now;

            Console.WriteLine("Press any key to stop the time");
            Console.ReadKey();
            Console.WriteLine(" ");
            DateTime stoptime = DateTime.Now;

            TimeSpan elapsed = starttime - stoptime;
            Console.WriteLine("Elapsed time " + elapsed);
        }
    }
}
