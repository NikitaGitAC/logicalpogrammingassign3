using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logical_programming_problems
{
    internal class ReverseNumber
    {
        public static void findreversenum()
        {
            int remainder;
            int reverse = 0;
            int original;
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            original = num;
            remainder = num % 10;
            reverse = reverse * 10 + num;
            num = num / 10;
            Console.WriteLine("original num = " + original);
            Console.WriteLine("reverse num = " + reverse);

        }
    }
}
