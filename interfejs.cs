using System;

namespace Zadanie{

    interface IOdprawa{ // I jest po to by odroznic interface od class (interface nie robi nigdy obiektow)
        void odprawSie();
    }
    abstract class Osoba{
        public string imie {get; set;}
    }
    class Pracownik : Osoba{

    }
    class Kierownik : Osoba, IOdprawa{ //klasa rozszerzona o interfejs (mozna rozszerzac o tyle ile interfejsow sie chce)
        public void odprawSie(){
            System.Console.WriteLine("Kierownik odprawia sie");
        }  
    }
    class Program{

        static void Main(string[] args)
        {
            
        }
    }
}
