using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1
            /*
            int a = int.Parse(Console.ReadLine());
            if (a % 3 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            // Zad 2
            /*
            int a = int.Parse(Console.ReadLine());
            if (a >= 100 && a < 1000 && a % 17 == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            // Zad 3
            /*
            int wiek = int.Parse(Console.ReadLine());
            if(wiek >= 18)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            // Zad 4
            /*
            int waga, limit;
            waga = int.Parse(Console.ReadLine());
            limit = 20;
            if(waga > limit)
            {
                Console.WriteLine("NIE");
            }
            else
            {
                Console.WriteLine("TAK");
            }
            */

            // Zad 5
            /*
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if((a > c) && (b < c) || (b < c) && (a > c))
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */

            // Zad 6
            /*
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if((Math.Pow(a, p) - a) % p == 0)
            {
                Console.WriteLine("TAK");
            }
            else
            {
                Console.WriteLine("NIE");
            }
            */
            // Zad 7
            /*
            int p = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            if ((p + 3*s) >= k)
            {
                Console.WriteLine("TAK, zaba da rade");
            }
            else
            {
                Console.WriteLine("NIE, nie da rady");
            }
            */
            Console.ReadKey();
        }
    }
}
