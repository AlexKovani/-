using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Асинхронное_программирование
{
    class Program
    {
       // Разработать асинхронный метод для вычисления факториала числа.
       // В методе Main выполнить проверку работы метода.
        static void Main(string[] args)
        {
            Console.WriteLine("Wwedite chislo:");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            //Factorial(n);
            Console.ReadKey();

        }

        static void Factorial(int n)
        {
            int f = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i==1)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(j+" ");
                    }
                    Console.WriteLine();
                }

                f *= i;
                Console.WriteLine(f);
                Thread.Sleep(10);
            }
            Console.WriteLine("Result = "+f);
     
        }
        
        static async void FactorialAsync(int n)
        {
            await Task.Run(()=> Factorial(n));
        }
    }
}
