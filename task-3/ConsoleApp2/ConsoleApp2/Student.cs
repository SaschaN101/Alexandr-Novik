using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        public string name;
        public int age;
        public int group;

        
    }
    struct Puple
    {
            public string name;
            public int age;
            public int group;

            public void Print2()
            {
                Console.WriteLine($"Имя: {name}, возраст {age}, группа N {group}");
            }
    }

   




}
