using System;

namespace Zadanie{

    class Osoby{

    }
    class Kierownik : Osoby{
        private int pesel;
        public string imie;
        public string nazwisko;
        public int godziny_Pracy;
        private string pracownicy;
        public void zlecUsluge(){

        }
        public void zamowCzesci(){
            
        }
        public void konserwujMaszyne(){
            
        }
    }
    class Spawacz : Osoby{
        private int pesel;
        public string imie;
        public string nazwisko;
        public int godziny_Pracy;
        public void produkuj(){
            
        }
        public void getZasoby(){

        }
    }
    class Zasoby{

    }
    class Czesc : Zasoby{

    }
    class Maszyna : Zasoby{

    }
    class Produkt{
        public Spawacz spawacz;
        public Zasoby zasoby;
    }
    class Program{

        static void Main(string[] args){

        }
    }
}
