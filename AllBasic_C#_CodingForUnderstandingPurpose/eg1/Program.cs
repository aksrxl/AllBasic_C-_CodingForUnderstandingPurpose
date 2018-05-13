using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eg1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Method.TowerOfHanoi(5, 'A', 'B', 'C');
            Console.ReadLine();
        }
    }

    public class Method
    {
        public static void TowerOfHanoi(int n, char A, char B, char C)
        {
            if (n == 1)
            {
                Console.WriteLine("Move disc no. {0} From {1} to {2}", 1,A,C);
            }
            else
            { 
            TowerOfHanoi(n - 1, A, C, B);
            Console.WriteLine("Move disc no. {0} From {1} to {2}", n, A, C);
            TowerOfHanoi(n - 1, B, A,C);
            }
}

    }
}
