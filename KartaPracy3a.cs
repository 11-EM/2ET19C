using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Zad 1
            Console.WriteLine("Proszę podać liczbe: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.Write("*-|");
            }*/

            /*Zad 2
            Console.WriteLine("Proszę podać liczbe: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("");
            }*/

            /*Zad 7
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i < n + 1; i++)
            {
                for(int j = 1; j < n + 1; j++)
                {
                    if (i == 1 || j == 1 || j == n || i == n || (i == n/2 + 1 && j == n/2 + 1)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }*/

            /*Zad 6
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == n - j + 1) Console.Write("?");
                    else if (i == j) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }*/

            /*Zad 5
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (j == n / 2 + 1) Console.Write("----*----");
                    else if (i == n / 2 + 1) Console.Write("-");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }*/

            //Zad 4
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i + j == n / 2 + 2 || i + j == n + n/2 + 1 || i - j == n/2 || i - j == -(n/2)) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
