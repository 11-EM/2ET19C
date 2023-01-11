using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cash
    {
        private float cashTendered;
    }
    class Check
    {
        private string name;
        private string bankID;
        public void authorized()
        {
            
        }
    }
    class Credit
    {
        private string name;
        private string type;
        private string expDate;
        public void authorized()
        {

        }
    }
    class Payment
    {
        private float amount;
    }
    class Customer
    {
        private string name;
        private string address;
    }
    class Item
    {
        private string shippingWeight;
        private string description;
        public void getPriceForQuantity()
        {

        }
        public void getTax()
        {

        }
        public void inStock()
        {

        }
    }
    class OrderDetail
    {
        private string quality;
        private string taxStatus;
        public void calcSubTotal()
        {

        }
        public void calcWeight()
        {

        }
        public void calcTax()
        {

        }
    }
    class Order
    {
        private string date;
        private string status;
        public void calcSubTotal()
        {

        }
        public void calcTax()
        {

        }
        public void calcTotal()
        {

        }
        public void calcTotalWeight()
        {

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
