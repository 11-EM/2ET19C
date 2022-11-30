using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /* kompozycja
    class Liver
    {
        private int weight;
        private string color;
    }
    class Heart
    {
        private int weight;
        private string condition;
    }
    class Body
    {
        private Liver liver;
        private Heart heart;
        public Body(Liver aliver, Heart aheart)
        {
            this.liver = aliver;
            this.heart = aheart;
        } 
        public void eat()
        {
            Console.WriteLine("mmmm");
        }
    }*/

    /* agregacja
    class Engine
    {
        private int pojemnosc;
        private int moc;
        public void start()
        {
            Console.WriteLine("Startuje");
        }
        public void stop()
        {
            Console.WriteLine("Stop");
        }
    }
    class Radio
    {
        private string model;
        private string typ;
        public void graj()
        {
            Console.WriteLine("radio gra");
        }
    }
    class Auto
    {
        private string color;
        private int year;
        private Engine engine;
        private Radio radio;
        public void jedz()
        {
            Console.WriteLine("No to jade");
        }
        public void napraw()
        {
            Console.WriteLine("Naprawiam");
        }
        public void setSilnik(Engine asilnik)
        {
            this.engine = asilnik;
        }
        public void zamontujRadio(Radio aradio)
        {
            this.radio = aradio;
        }
    }*/

    /* asocjacja
    class Skladnik
    {
        private string nazwa;
        private int kalorie;
        public Skladnik(string anazwa, int akalorie)
        {
            this.nazwa = anazwa;
            this.kalorie = akalorie;
        }
    }
    class Salatka
    {
        Skladnik s1;
        Skladnik s2;
        Skladnik s3;
        public void przygotuj()
        {
            Skladnik s = new Skladnik("marchew", 60);
            if (this.s1 == null)
            {
                this.s1 = s;
            }
            else
            {
                this.s2 = s;
            }
            Console.WriteLine("Przygotuj");
        }
        public void wydaj()
        {
            Console.WriteLine("Wydaj");
        }
    }
    class Danie
    {
        private string zupa;
        private string napoj;
        private Salatka salatka;
        public void przyrzadz(Salatka asalatka)
        {
            this.salatka = asalatka;
            Console.WriteLine("przyrzadz");
        }
        public void zjedz()
        {
            Console.WriteLine("zjedz");
        }
    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            /* kompozycja
            Liver l1 = new Liver();
            Heart h1 = new Heart();
            Body b1 = new Body(l1, h1);*/

            /* agregacja
            Engine s1 = new Engine();
            Auto a1 = new Auto();
            a1.setSilnik(s1);*/

            /* asocjacja
            Danie d = new Danie();
            Salatka s = new Salatka();
            s.przygotuj();
            d.przyrzadz(s);*/
        }
    }
}
