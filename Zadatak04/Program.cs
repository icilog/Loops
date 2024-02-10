using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            Console.WriteLine("Unesi broj: ");
            double n= double.Parse(Console.ReadLine());
            double temp = n;
            var znamenke = new List<double>();

            while (temp > 10)
            {
                znamenke.Add(temp % 10);
                temp = temp / 10;
            }
            znamenke.Add(temp);
            foreach (int a in znamenke)
            {
                suma= suma + Math.Pow(a,3);
            }
            if (suma == n) Console.WriteLine($"Broj {n} je Armstrongov broj");
            else Console.WriteLine($"Broj {n} nije Armstrongov broj, suma mu je {suma}");
            Console.ReadKey();
        }

    }
}
