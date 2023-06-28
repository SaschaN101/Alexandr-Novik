using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Person
    {
           
            public string name = "Undefined";
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя: {name}  Возраст: {age}");
            }
       

    }
    struct Person1
    {
        public string name;
        public int age;

        public void Print1()
        {
            Console.WriteLine($"Только имя: {name}, его возраст: {age}"); 
        }
    }



}
