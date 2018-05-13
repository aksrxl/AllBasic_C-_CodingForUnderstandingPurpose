using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOccurenceOfNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] series = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] num = new int[] { 1, 1, 1, 3, 4, 3, 5, 6 };

            int l = num.Length;
            int j = 0;
            while (j < l)
            {
                series[num[j]]++;
                j++;
            }

            foreach (var x in series)
            { Console.WriteLine(x); }

            for (int i = 0; i < series.Length; i++)
            {
                Console.WriteLine("The number {0} has occurred {1} times", i, series[i]);
            }
            Console.ReadLine();
        }
    }
}
