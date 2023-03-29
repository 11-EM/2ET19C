using System;

namespace Zadanie{

    interface IRemote{
        void zdalnie();
    }
    interface IKeyless{
        void wejdz();
    }
    abstract class Auta{
        public abstract string Model {get; set;}
        public virtual void jedz(){
            System.Console.WriteLine("jedz");
        }
    }
    class Mercedes : Auta, IKeyless{
        public string _model;
        public override string Model(){
            get{
                return _model;
            }
            set{
                _model = value;
            }
        }
        public override void jedz(){
            System.Console.WriteLine("jade");
        }
        public void zdalnie(){
            System.Console.WriteLine("zdalnie");
        }
        public void wejdz(){
            System.Console.WriteLine("wejdz");
        }
    }
    class Audi : Auta, IRemote, IKeyless{
        public string _model;
        public override string Model(){
            get{
                return _model;
            }
            set{
                _model = value;
            }
        }
        public override void jedz(){
            System.Console.WriteLine("jade");
        }
        public void zdalnie(){
            System.Console.WriteLine("zdalnie");
        }
        public void wejdz(){
            System.Console.WriteLine("wejdz");
        }
    }
    class BMW : Auta, IRemote{
        public string _model;
        public override string Model(){
            get{
                return _model;
            }
            set{
                _model = value;
            }
        }
        public override void jedz(){
            System.Console.WriteLine("jade");
        }
        public void zdalnie(){
            System.Console.WriteLine("zdalnie");
        }
    }
    class Program{

        static void Main(string[] args)
        {
            
        }
    }
}
