using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Car
    {
        public string brend;
        public string type;
        public double price;

        public void Print()
        {
            Console.WriteLine("Купил новую машину");

            Console.WriteLine($"Марка: {brend}, тип кузова: {type}, стоимость: {price} $");
        }

        public Car()
        {
            brend = "Неизвестно";
            type = "sedan";
            price = 1000;
        }
        public Car(string s)
        {
            brend = s;
        }
        public Car(string s, string st)
        {
            brend = s;
            type = st;
        }
        public Car(string s, string st, double pr)
        {
            brend = s;
            type = st;
            price = pr;
        }
        public Car(double pr) { price = pr; }

        public void Deconstruct (out string brendName, out string typeName, out double priceName) 
        {
            brendName = brend;
            typeName = type; priceName = price;
        }
    }

   
}
