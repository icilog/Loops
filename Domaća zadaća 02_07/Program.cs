using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaća_zadaća_02_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] m = new int[11, 11];
            // punimo matricu sa brojevima 1-10
            for (int i = 1; i < 11; i++)
            {
                m[0, i] = i;
                m[i,0] = i;
            }
            // izrađujemo tablicu množenja
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    m[i, j] = m[0, j] * m[i,0];
                }
            
            }
            // ispisujemo matricu
            for (int redak = 0; redak < 11; redak++)
            {
                for (int stupac = 0; stupac < 11; stupac++)
                {
                    Console.Write(m[redak, stupac] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
