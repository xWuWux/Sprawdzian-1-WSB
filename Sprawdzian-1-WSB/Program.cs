using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprawdzian_1_WSB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 3, 5, 7 };
            List<int> list1 = new List<int>() { 1, 3, 5, 7 };

            //
            // Use Sum extension on their elements.
            //
            int sum1 = array1.Sum();
            int sum2 = list1.Sum();

            //
            // Write results to screen.
            //
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
        }
    }
}
