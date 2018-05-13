using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace parallelForAndForeach
{
    class Program
    {
        static void Main(string[] args)
        {

            //Parallel.For(0, 10, (i) =>
            //    {
            //        Console.WriteLine(i);
            //        Thread.Sleep(1000);
            //    });

            int[] x= new int[] {9,293,434,545,576,687,788,899,900};
            Parallel.ForEach(x,(i)=>{
                Console.WriteLine(i);
                });
            Console.ReadLine();
                
        }
    }
}
