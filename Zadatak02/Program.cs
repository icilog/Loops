using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int suma = 0;
            Console.WriteLine("Unesi broj: ");
            n = Int32.Parse(Console.ReadLine());    
            for (int i = 1; i <= n; i++)
            {
                suma+= i;
            }

            Console.WriteLine($"Suma svih brojeva do broja {n} je {suma}");
            Console.ReadKey();
        }
    }
}
