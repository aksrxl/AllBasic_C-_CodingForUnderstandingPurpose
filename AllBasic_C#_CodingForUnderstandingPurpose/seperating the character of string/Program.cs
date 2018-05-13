using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seperating_the_character_of_string
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "MyNameIsAnish";
            char[] charname = name.ToCharArray();
            int l=0;
            while(l < name.Length)
            {
            Console.Write( "{0} ",charname[l]);
            
            l++;
            }
            Console.ReadLine();
            

        }
    }
}
