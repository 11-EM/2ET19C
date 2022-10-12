using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        /*kp1z1
        public static int kp1z1(int a, int b)
        {
            return a * a + b * b;
        }*/

        /*kp2z2
        public static bool kp2z2(int a)
        {
            if(a >= 100 && a <= 1000 && a % 17 == 0){
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*kp2z6
        public static bool kp2z6(int a, int p)
        {
            if((Math.Pow(a, p)-p) % a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/

        /*kp3z1
        public static void kp3z1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * i * i + 3 + " ");
            }
        }*/

        /*kp3z3
        public static ArrayList kp3z3(int x)
        {
            ArrayList alist = new ArrayList();
            for(int i = 1; i < x+1; i++)
            {
                if(x % i == 0)
                {
                    alist.Add(i);
                }
            }
            return alist;
        }*/
        static void Main(string[] args)
        {
            /*kp1z1
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(kp1z1(a, b));*/

            /*kp2z2
            Console.WriteLine(3 > 6 ? "TAK" : "NIE");*/

            /*kp2z6
            int a = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine(kp2z6(a, p));
            Console.ReadKey();*/

            /*kp3z1
            int n = int.Parse(Console.ReadLine());
            kp3z1();*/

            /*kp3z3
            ArrayList dzielniki = new ArrayList();
            int n = int.Parse(Console.ReadLine());
            dzielniki = kp3z3(n);
            foreach(int a in dzielniki)
            {
                Console.WriteLine(a + " ");
            }*/
        }
    }
}
