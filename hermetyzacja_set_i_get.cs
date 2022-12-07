using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Herbata
    {
        public string KrajPochodzenia;
        public string nazwa;
        public string aromat;
        public void sparz()
        {
            Console.WriteLine("Sparz");
        }
    }
    class Termos
    {
        private int pojemnosc;
        private int waga;
        private int cena;
        public Herbata herbata;
        public string zawartosc = "Herbata";
        public void setPojemnosc(int poj)
        {
            this.pojemnosc = poj;
        }
        public int getPojemnosc()
        {
            return this.pojemnosc;
        }
        public void setWaga(int wag)
        {
            this.waga = wag;
        }
        public int getWaga()
        {
            return this.waga;
        }
        public void setCena(int cen)
        {
            this.cena = cen;
        }
        public int getCena()
        {
            return this.cena;
        }
        public Termos(Herbata aherbata)
        {
            this.herbata = aherbata;
        }
        public void polej()
        {
            Console.WriteLine("Polej");
        }
        public void umyj()
        {
            Console.WriteLine("Umyj");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Herbata h1 = new Herbata();
            Termos t1 = new Termos(h1);
        }
    }
}
