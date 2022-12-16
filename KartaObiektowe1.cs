using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania{
   
    class Producent
        {
            private string nazwa;
            private string nip;
            public string getNazwa()
            {
                return "nazwa";
            }
            public string getNip()
            {
                return "nip";
            }
            public string setNazwa()
            {
                return "nazwa";
            }
        }
        class Material
        {
            private string typ;
            private int id;
            private double cena;

            public string setType()
            {
                return "type";
            }
            public string getType()
            {
                return "type";
            }
            public double getCena()
            {
                return cena;
            }
            public int setId()
            {
                return id;
            }
        }
        class Rower
        {
            public Producent producent;
            public Material material;
            private string Producent;
            private string Kolor;
            private string Material;
            public string jedz()
            {
                return "Jade";
            }

            public void setColor(string aKolor)
            {
                this.Kolor = aKolor;
            }
            public string getColor()
            {
                return Kolor;
            }
            public void setMaterial(Material amaterial)
            {
                this.material = amaterial;
            }
            public Rower(Producent aproducent)
            {
                this.producent = aproducent;
            }
        }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Producent p1 = new Producent();
            Rower r1 = new Rower(p1);
            Material m1 = new Material();
            r1.setMaterial(m1);
        }
    }
}

