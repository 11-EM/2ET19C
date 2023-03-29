using System;

namespace Zadanie{

    abstract class Auto{
        public abstract string Model();
    }
    class Audi : Auto{
        public string _model;
        public override string Model{
            get{
                return _model;
            }
            set{
                _model = value;
            }
        }
    }
    class Mercedes : Auto{
        public string _model;
        public override string Model{
            get{
                return _model;
            }
            set{
                _model = value;
            }
        }
    }
    class Program{

        static void Main(string[] args)
        {
            Audi a = new Audi();
            a.Model = "R8";
            System.Console.WriteLine(a.Model);
        }
    }
}
