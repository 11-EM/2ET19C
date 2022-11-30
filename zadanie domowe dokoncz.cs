using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Contact
    {
        private string emailAddress;
        private string faxnumber;
        private string name;
        private string primaryContactMethod;
        public string getEmailAddress()
        {
            return "metoda 1 w klasie 1";
        }
        public string ggetFaxNumber()
        {
            return "metoda 2 w klasie 1";
        }
        public string getName()
        {
            return "metoda 3 w klasie 1";
        }
        public string getPrimaryContactMethod()
        {
            return "metoda 4 w klasie 1";
        }
        public string setEmailAddress()
        {
            return "metoda 5 w klasie 1";
        }
        public string setFaxNumber()
        {
            return "metoda 6 w klasie 1";
        }
        public string setName()
        {
            return "metoda 7 w klasie 1";
        }
        public string setPrimaryContactMethod()
        {
            return "metoda 8 w klasie 1";
        }
    }
    class AddressBook
    {
        private string name;
        private Contact contact;
        public AddressBook(Contact acontact)
        {
            this.contact = acontact;
        }
        public void getContact()
        {
            Console.WriteLine("metoda 1 z klasy 2");
        }
        public void getContacts()
        {
            Console.WriteLine("metoda 2 z klasy 2");
        }
        public void getName()
        {
            Console.WriteLine("metoda 3 z klasy 2");
        }
        public void insertContact()
        {
            Console.WriteLine("metoda 4 z klasy 2");
        }
        public void setName()
        {
            Console.WriteLine("metoda 3 z klasy 2");
        }
    }
    class Account
    {
        private string emailAddress;
        private string name;
        private AddressBook book;
        public void getAddressBook(AddressBook abook)
        {
            this.book = abook;
        }
        public string getEmailAddress()
        {
            return "metoda 1 z klasy 3";
        }
        public string getName()
        {
            return "metoda 2 z klasy 3";
        }
        public string setEmailAddress()
        {
            return "metoda 3 z klasy 3";
        }
        public string setName()
        {
            return "metoda 4 z klasy 3";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact();
            AddressBook a1 = new AddressBook(c1);
            Account ac1 = new Account();
            ac1.getAddressBook(a1);
        }
    }
}
