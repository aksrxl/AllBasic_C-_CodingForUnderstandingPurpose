using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfWordsInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "My Name is Anish";
            char[] charname = name.ToCharArray();

            int l = name.Length-1;
            int wrd = 0;
            while (l >= 0)
            {
                if(name[l] == ' ' || name[l]== '\n' || name[l]== '\t')
                                        
                {
                    wrd++;
                }
                l--;
            }

            Console.WriteLine("The total number of words are {0}", wrd+1);
            Console.ReadLine();
        }
    }
}
