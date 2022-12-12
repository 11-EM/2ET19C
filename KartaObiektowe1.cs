using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class Material{
        public string typ;
        public int id;
        public double cena;
        public void setTyp(){
            System.Console.WriteLine("setTyp");
        }
        public void getTyp(){
            System.Console.WriteLine("getTyp");
        }
        public void getCena(){
            System.Console.WriteLine("getCena");
        }
        public void setId(){
            System.Console.WriteLine("setId");
        }
    }
    class Producent{
        public string nazwa;
        public string nip;
        public void getNazwa(){
            System.Console.WriteLine("getNazwa");
        }
        public void getNip(){
            System.Console.WriteLine("getNip");
        }
        public void setNazwa(){
            System.Console.WriteLine("setNazwa");
        }
    }
    class Rower{
        public Producent producent;
        public string kolor;
        public Material material;
        public void jedz(){
            System.Console.WriteLine("jedz");
        }
        public void setColor(){
            System.Console.WriteLine("setColor");
        }
        public void getColor(){
            System.Console.WriteLine("getColor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Producent p = new Producent();
            Material m = new Material();
            Rower r = new Rower(p, m);
        }
    }
}
