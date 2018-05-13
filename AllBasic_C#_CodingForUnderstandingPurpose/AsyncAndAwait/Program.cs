using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace AsyncAndAwait
{
    public class Program
    {
        static void Main(string[] args)
        {
            //without async and await

            //printAnumberWithOutAsyncAwait();
            //PrintSomething();

            // with async and await
            printAnumberWithAsyncAwait();
            PrintSomething();

            var x= printIdWithAsyncAndAwait().Result;

           Console.ReadLine();
           }

       


      

        public static void PrintSomething()
        {
            Console.WriteLine("Something... something");
        }

       

        #region withAsyncAndAwait
        public static async Task<int> printIdWithAsyncAndAwait()
        {
            string connectionstring = "Data Source=PAPABOSS-PC\\VSTUDIO;Initial Catalog=EmployeeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select top 1 id from employees", con);
                var x = await Task.Run(
                    () => cmd.ExecuteScalar()
                    );
                Thread.Sleep(5000);
                return (int)x;
            }
        }

        public static async void printAnumberWithAsyncAwait()
        {
            var y = await printIdWithAsyncAndAwait();
            Console.WriteLine(y);
        }
        #endregion

        #region withOutAsyncAndAwait

        public static int printIdWithoutAsyncAndAwait()
        {
            string connectionstring = "Data Source=PAPABOSS-PC\\VSTUDIO;Initial Catalog=EmployeeDB;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("select top 1 id from employees", con);
                var x = cmd.ExecuteScalar();
                Thread.Sleep(5000);
                return (int)x;
            }
        }

        public static void printAnumberWithOutAsyncAwait()
        {
            var x = printIdWithoutAsyncAndAwait();
            Console.WriteLine(x);
        }

        #endregion

       

    }
}
