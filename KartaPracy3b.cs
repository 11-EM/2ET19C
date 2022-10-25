using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
    namespace Zadania{
        class Program
        {
            static void Main(string[] args)
            {
                /*Zad 1
                Console.WriteLine("Dni listopada:");
                for (int i = 1; i <= 30; i++)
                {
                    Console.Write($"{i}, ");
                }*/

                /*Zad 2
                Console.WriteLine("Prosze podac ilość iczb: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i += 2)
                {
                    Console.Write($"{i * i}, ");
                }*/

                /*Zad 3
                for (int i = 1000; i < 10000; i++)
                {
                    if(i % 379 == 0) 
                    {
                        Console.Write($"{i}, ");
                    }
                }*/

                /*Zad 4
                for (int i = 100; i < 1000; i++)
                {
                    if (i % 5 == 0  i % 6 == 0  i % 11 == 0)
                    {
                        Console.Write($"{i}, ");
                    }
                }*/

                /*Zad 5
                Console.WriteLine("Prosze podac ilość liczb: ");
                int nliczb = int.Parse(Console.ReadLine());
                int a = 0;
                int suma = 0;
                for (int i = 0; i < nliczb; i++)
                {
                    Console.WriteLine($"Prosze podac {i + 1} liczbe: ");
                    a = int.Parse(Console.ReadLine());
                    suma += a;
                }
                Console.WriteLine($"{suma}");*/

                /*Zad 6
                int k = 0, w;
                while(k != 10){
                    k = k + 2;
                    w = k + k;
                    Console.WriteLine($"{w},");
                }*/

                /*Zad 7
                Console.WriteLine("Prosze podac ilosc liczb: ");
                int m = int.Parse(Console.ReadLine());
                int suma = 0;
                for(int i = 11; i < (n * 2) + 10; i += 2){
                    suma += i;
                }
                Console.WriteLine($"Suma liczb: {suma}");*/

                /*Zad 9
                Console.WriteLine("Prosze podac liczbe: ");
                int n = int.Parse(Console.ReadLine());
                int suma = 0;
                for (int i = 21; i <= (n-1)100+21; i+=100)
                {
                    suma += i;
                }
                Console.WriteLine($"Suma wynosi {suma}");*/
            }
        }
    }
