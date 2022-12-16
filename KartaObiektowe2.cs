using System;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication.ExtendedProtection;

namespace Zadania
{
    class Profil
    {
        private string imie;
        private string drugieimie;
        private string nazwisko;

        public string getImie()
        {
            return "imie";
        }
        public string getNazwisko()
        {
            return "nazwisko";
        }
    }
    class Produkt
    {
        private string nazwa;
        private double cena;
        private string opis;

        public string getNazwa()
        {
            return "nazwa";
        }
        public string getCena()
        {
            return "cena";
        }
        public string getOpis()
        {
            return "opis";
        }
        public Produkt()
        {
            nazwa = nazwa;
        }
        public Produkt(string anazwa, double acena, string aopis)
        {
            this.nazwa = anazwa;
            this.cena = acena;
            this.opis = aopis;
        }

    }
class Uzytkownik
    {
        private string login;
        private string haslo;
        private Profil profil;

        public void loguj()
        {
        }
        public Uzytkownik()
        {
        }
        public Uzytkownik(Profil aprofil)
        {
            this.profil = aprofil;
        }
    }

    class Koszyk
    {
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;

        public int getId()
        {
            return id;
        }
        public string operation()
        {
            return "operation";
        }
        public void setUzytownik(Uzytkownik auzytkownik)
        {
            this.uzytkownik = auzytkownik;
        }
        public Koszyk(Produkt aprodukt)
        {
            this.produkt = aprodukt;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Produkt p1 = new Produkt();
            Profil pr1 = new Profil();
            Uzytkownik u1 = new Uzytkownik(pr1);
            Koszyk k1 = new Koszyk(p1);
        }
    }
}
