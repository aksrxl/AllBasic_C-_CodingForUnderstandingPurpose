using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfAlphaNumberSpcl
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Hello How are You $$#1234";

            int alpha, num, spcl, i ;
            alpha = num = spcl = i = 0;
            int l= name.Length-1;

            while (i <= l)
            { 
            
               string name1= name.ToUpper();
               if (name1[i] >= 'A' && name1[i] <= 'Z')
               {
                   alpha ++;
               }
                else if (name[i] >= '0' && name[i] <= '9')
               {
                   num++;
               }

               else
                   spcl++;
               i++;
            }
            Console.WriteLine(name);
            Console.WriteLine("Total number of alphabet is {0}", alpha);
            Console.WriteLine("Total number of digit is {0}", num);
            Console.WriteLine("Total number of spcl is {0}", spcl);
            Console.ReadLine();
        }
    }
}
