using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Console.WriteLine("Unesi broj: ");
            int n = Int32.Parse(Console.ReadLine());
            var znamenke = new List<int>();

            while(n > 10)
            {
                    znamenke.Add(n%10);
                    n = n / 10; 
            }
            znamenke.Add(n);
            foreach (int a in znamenke)
            {
                suma += a;
            }
            Console.WriteLine($"Zbroj znamenki u vašem broju je {suma}");
            Console.ReadKey();
        }
    }
}
