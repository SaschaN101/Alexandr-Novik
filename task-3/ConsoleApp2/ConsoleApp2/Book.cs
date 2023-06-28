using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class Book
    {
        public string title;
        public string color;
        public int page;

        public Book (string title, string color, int page)
        {
            this.title = title;
            this.color = color;
            this.page = page;
        }
        /*public void Print()
        { Console.WriteLine($"Я прочел книгу {title}, {color} цвета, {page} страниц"); }*/

        public void Deconstruct(out string boocTitle, out string boocColor, out int boocPage)
        //      public void Deconstruct
        {
            boocTitle = title;
            boocColor = color;
            boocPage = page;
        }


    }

    struct newBook
    {
        public string title;
        public string color;
        public int page;

        public void Print()
        { Console.WriteLine($"Я прочел книгу {title}, {color} цвета, {page} страниц"); }
    }

}