using System;

namespace Zadanie{

    /*abstract class Osoba{
        public string imie {get; set;}
        private int wiek;
        
    }
    class Pracownik : Osoba{

    }
    class Kierownik : Osoba{

    }*/

    abstract class Osoba{
        abstract public void przywitaj(); //gdy metoda jest abstrakcyjna to nie mozna jej wywolac i nie moze miec tresci (i klamr czyli sam tytul)
        //jezeli klasa ma cos abstrakcyjnego to sama musi byc abstrakcyjna
        
        void porzegnaj(){ //ta metoda jest bez sensu w klasie osoba lecz w innych mozna jej uzyc
            System.Console.WriteLine("Naura");
        }
    }
    class Nauczyciel : Osoba{
        public override void przywitaj() //override nadpisuje metode z klasy dziedziczacej
        {
            System.Console.WriteLine("elo");
        }
    }
    class Uczen : Osoba{
        public override void przywitaj() //override nadpisuje metode z klasy dziedziczacej
        {
            System.Console.WriteLine("welcum");
        }
    }
    class Program{

        static void Main(string[] args)
        {
            /*Kierownik k = new Kierownik();
            k.imie = "Marcin";
            Osoba os = new Osoba(); //nie mozna tworzyc obiektow w osobie jak klasa jest abstrakcyjna*/
            Uczen u = new Uczen();
            u.przywitaj();
            u.porzegnaj();
        }
    }
}
