﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(
                () =>
                {
                    return 45;
                }
                );
           // t.Wait();
            Console.WriteLine(t.Result);
           t= t.ContinueWith((i)=>{
            return i.Result*2;
            });
            Console.WriteLine(t.Result);
            Console.ReadLine();

        }
    }
}
