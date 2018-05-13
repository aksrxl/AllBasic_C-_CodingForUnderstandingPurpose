using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoral
{
    class Program
    {
        static void Main(string[] args)
        {
        //    long fact = 1;
        //        int i=15;
        //    while(i!=0)
        //    {
        //    fact=fact*i;
        //        i--;
        //    }

        //    Console.WriteLine(fact);
        //    Console.ReadLine();
        //}
            long sum = 0;

            for (int i = 105; i <= 8995; i += 7)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            }
       


    }
}
