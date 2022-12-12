using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Produkt{
        private string nazwa;
        private double cena;
        private string opis;
        public void getNazwa(){
            System.Console.WriteLine("getNazwa");
        }
        public void getCena(){
            System.Console.WriteLine("getCena");
        }
        public void getOpis(){
            System.Console.WriteLine("getOpis");
        }
        public void Produkt(nazwa, cena, opis){
            System.Console.WriteLine("Produkt");
        }
    }
    class Profil{
        private string imie;
        private string drugieImie;
        private string nazwisko;
        public void getImie(){
            System.Console.WriteLine("getImie");
        }
        public void getNazwisko(){
            System.Console.WriteLine("getNazwisko");
        }
    }
    class Uzytkownik{
        private string login;
        private string haslo;
        private Profil profil;
        public void loguj(){
            System.Console.WriteLine("loguj");
        }
    }
    class Koszyk{
        private int id;
        private Produkt produkt;
        private Uzytkownik uzytkownik;
        public void getId(){
            System.Console.WriteLine("getId");
        }
        public void operation(){
            System.Console.WriteLine("operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Produkt prod1 = new Produkt();
            Profil prof1 = new Profil(prod1);
            Uzytkownik uzy1 = new Uzytkownik(prof1);
            Koszyk kosz1 = new Koszyk(uzy1);
        }
    }
}
