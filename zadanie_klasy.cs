using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Typ
    {
        public string kategoria;
    }

    class Pracownik
    { 
        public string imie;
        public string nazwisko;
        public string dataPrzyjecia;
    }

    class Dzial
    {
        public int numerDzialu; 
        public void PoszukajDzialu()
        {
            Console.WriteLine("Szukam dzialu");
        }
    }

    class Polka
    {
        public int nrPolki;
        public string Litera;
        public void OdlozKsiazka()
        {
            Console.WriteLine("Odkladam ksiazke");
        }
    }

    class Egzemplarz
    {
        public int ilosc;
        public void SprawdzIlosc()
        {
            Console.WriteLine("Sprawdzam ilosc");
        }
    }

    class Stan
    {
        public string stanKsiazki;
        public void SprawdzStan()
        {
            Console.WriteLine("Sprawdzam stan");
        }
    }
    class Ksiazka
    {
        public Dzial dzial;
        public string autor;
        public string dataWydania;
        public void getTyp()
        {
            Console.WriteLine("Nadaje typ");
        }

        public void SzukajKsiazki()
        {
            Console.WriteLine("Szukam ksiazki");
        }

        public void getDzial()
        {
            Console.WriteLine("Nadaje dzial");
        }

        public void ZglosZapotrzebowanie()
        {
            Console.WriteLine("Zglaszam zapotrzebowanie");
        }

        public void getEgzemplarz()
        {
            Console.WriteLine("Nadaje egzemplarz");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
