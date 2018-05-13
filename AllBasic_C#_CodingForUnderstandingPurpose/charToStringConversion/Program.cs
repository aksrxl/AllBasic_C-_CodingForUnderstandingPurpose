using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charToStringConversion
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "My Name is Anish";
            char [] charname = name.ToCharArray();
            int len = 0;
            foreach (char chr in charname)
            {
                len++;
            }
            Console.WriteLine(name.Length);
            Console.WriteLine(len);
            Console.ReadLine();

        }
    }
}
