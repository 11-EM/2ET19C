using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Program
    {
        /*Zad 1
        public static int Zad1(int a, int b)
        {
            int suma;
            suma = a + b
            if(suma % 2 == 0){
                return true;
            }
            else{
                return false;
            }
        }*/
        
        /*Zad 2
        public static int Zad2(int a, int g,)
        {
            int avga, avgg;
            avga = (a + g) / 2;
            avgg = (a * g) * (a * g);
            if (avga > avgg)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        
        /*Zad 3
        public static int Zad3(int k, int l, int m)
        {
            if(k == l)
            {
                Console.WriteLine($"{k}, {l}");
                return true;
            }
            else if(k == m)
            {
                Console.WriteLine($"{k}, {m}");
                return true;
            }
            else if(l == m)
            {
                Console.WriteLine($"{l}, {m}");
                return true;
            }
            else
            {
                return false;
            }
        }*/
        
        /*Zad 4
        public static int Zad4(int a, int b, int c, int d)
        {
            if(a < b && a < c && a < d)
            {
                return a;
            }
            else if(b < a && b < c && b < d)
            {
                return b;
            }
            else if(c < a && c < b && c < d)
            {
                return c;
            }
            else if(d < a && d < c && d < b)
            {
                return d;
            }
        }*/
        
        /*Zad 5
        public static int Zad5(int a, int b, int c)
        {
            if(a + b < c)
            {
                return true;
            }
            else if(a + c < b)
            {
                return true;
            }
            else if(b + c < a)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
        
        /*Zad 6
        public static int Zad6(int a, int b, int c)
        {
            if(a == b && b == c)
            {
                Console.WriteLine("Ostrokątny");
            }
            else if(a == 90)||(b == 90)||(c == 90)
            {
                Console.WriteLine("Prostokątny");
            }
            else if(a >= 90)||(b >= 90)||(c >= 90)
            {
                Console.WriteLine("Rozwartokątny");
            }
        }*/
        static void Main(string[] args)
        {
            /*Zad 1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad1(a, b));*/
            
            /*Zad 2
            int a = int.Parse(Console.ReadLine());
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad2(a, g));*/
            
            /*Zad 3
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad3(k, l, m));*/
            
            /*Zad 4
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad4(a, b, c, d));*/
            
            /*Zad 5
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad5(a, b, c));*/
            
            /*Zad 6
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Zad6(a, b, c));*/
            Console.ReadKey();
        }
    }
}
