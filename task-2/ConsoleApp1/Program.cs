using System;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Определите переменные всех возможных примитивных типов С#

            /*
                        int x;
                         Console.WriteLine("Введите число типа int");
                        x = Int32.Parse(Console.ReadLine());           
                        Console.WriteLine(x);

                        long xxxx;
                         Console.WriteLine("Введите число типа long");
                        xxxx = Convert.ToInt64(Console.ReadLine());           
                        Console.WriteLine(xxxx);

                         float fla;
                         Console.WriteLine("Введите число типа float");
                         fla = float.Parse(Console.ReadLine());
                         Console.WriteLine(fla);

                        ushort ush;
                        Console.WriteLine("Введите число типа ushort");
                        ush = Convert.ToUInt16(Console.ReadLine());
                        Console.WriteLine(ush);


                         Console.WriteLine("Введите bool");
                        bool boolStr = Boolean.Parse(Console.ReadLine());      
                        Console.WriteLine(boolStr);


            // приведение типов
            double a = 4.0;
            decimal b = (decimal)a;
            Console.WriteLine(b);
            
            int a1 = 10;
            double b1 = (double)a1;
            Console.WriteLine(a1);


            float a2 = 65.35f;
            double b2 = (double)a2;
            Console.WriteLine(a2);

           string str1 = Console.ReadLine();
            byte s_byte = byte.Parse(str1);
            Console.WriteLine(s_byte);
            int abc = 5;
            s_byte = Convert.ToByte(abc);           
            Console.WriteLine(s_byte);
            s_byte = Convert.ToByte(a2);
            Console.WriteLine(s_byte);

            ushort s_ushort1 = Convert.ToUInt16(a2);
            Console.WriteLine(s_ushort1);
            ushort s_ushort2 = ushort.Parse(str1);
            Console.WriteLine(s_ushort2);
            Console.WriteLine("Введите число типа int");
            var x = Convert.ToInt32(Console.ReadLine());
            var intX = new[] {1, 5, 15 };
            var stringX = new[] { "Hello", "World", "7"};
            int intXnIndex2 = intX[2];
            string stringXIndex0 = stringX[0];
            Console.WriteLine(intXnIndex2 + " _ " + stringXIndex0);*/



            string? stringNullable = null;
            void IsNull(string? obj)
            {
                if (obj == null)
                {
                    Console.WriteLine("stringNullable = null");

                } else Console.WriteLine($"stringNullable = {obj}");
            }
            IsNull(stringNullable);
            var test = "22";
            stringNullable = "abcd";
            IsNull(stringNullable);
            IsNull(test);


            // test = 22; - за переменной test закреплен тип string, который не может измениться до конца существования переменной test на другой тип

            Console.ReadLine();

        }
        

            

    }   
}