using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число ");
            int n = Convert.ToInt32(Console.ReadLine());
            int r = Method1Async(n).Result;
            Console.WriteLine($"Факториал = {r}");
            Console.ReadKey();
        }
        static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }

        static async Task<int> Method1Async(int n)
        {

            int result = await Task.Run(() => Factorial(n));
            return result;
        }
    }
}
