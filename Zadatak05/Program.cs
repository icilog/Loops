using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Unesi broj:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    suma += i;
                }
            }
            if (n == suma)
                Console.WriteLine($"Broj {n} je savršen broj, suma njegovih djelitelja je {suma}");
            else 
                Console.WriteLine($"Broj {n} nije savršen broj, suma njegovih djelitelja je {suma}");
            Console.ReadKey();
        }
    }
}
