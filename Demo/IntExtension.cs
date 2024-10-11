using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class IntExtension
    {
        public static int Reverse(this int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }

        public static long Reverse(this long number)
        {
            long reverse = 0;
            while (number > 0)
            {
                long remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            return reverse;
        }
    }
}
