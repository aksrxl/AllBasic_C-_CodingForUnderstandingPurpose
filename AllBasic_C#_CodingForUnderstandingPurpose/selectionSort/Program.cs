using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[] {5,2,1,6,3};
            Method m1 = new Method();
            foreach (var array in x)
            {
                Console.Write(array);
            }
            Console.WriteLine();
           
            m1.ArraySort(x);

            foreach (var array in x)
            {
                Console.Write(array);
            }
            Console.ReadLine();
        }
    }

    public  class Method
    {
       public  void ArraySort(int[] x)
        {
           int temp=0;

           //5,2,1,6,3
            for (int k = 0; k <= x.Length - 1; k++)
            {
                for (int i = 0; i <= x.Length - 2; i++)
                {
                    if (x[i] > x[i + 1])
                    {
                        temp = x[i];
                        x[i] = x[i + 1];
                        x[i + 1] = temp;
                    }
                }
            }

        }
    }
}
