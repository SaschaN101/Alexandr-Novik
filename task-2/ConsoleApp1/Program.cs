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
            Console.WriteLine(b);*/

            /*int a1 = 10;
            float _a1 = a1;
            Console.WriteLine(a1);//10
                                  // double b1 = (double)a1;
                                  // Console.WriteLine(a1);

            
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
            var _intA = 10; // 10
            var _charA = 'a';// a
            var __stringA = "str"; // str
            var intX = new[] {1, 5, 15 };
            var stringX = new[] { "Hello", "World", "7"};
            int intXnIndex2 = intX[2];
            string stringXIndex0 = stringX[0];
            Console.WriteLine(intXnIndex2 + " _ " + stringXIndex0);*/



            /* string ? stringNullable = null;

            Console.WriteLine(stringNullable);
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
            int? val = null;
            Console.WriteLine(val);*/



            // строки
            ///а
            string str1 = "AAAbbbCCC";
            string str2 = "ddEEff";
            string str3 = "GHK";
           
            // сцепление
            string str4 = str1 + str2 + str3;
            Console.WriteLine(str1 + str2 + str3);
            Console.WriteLine(str4);
            
            

            /// копирование
            string str5 = str4;
            Console.WriteLine("str 5 = " + str5);
            Console.WriteLine("str 4 = " + str4);
            str4 = "vasav";
            Console.WriteLine("str 4 = " + str4);
            Console.WriteLine("str 5 = " + str5);

            //метод CopyTo: копирует часть строки, начиная с определенного индекса в массив
            char[] arr = new char[str4.Length];
            str4.CopyTo(0, arr, 0, str4.Length);
            Console.WriteLine();
            foreach (char c in arr) { Console.Write(c); }

            // метод Insert: вставляет в строку подстроку
            string str6 = str4.Insert(3, str5);
            Console.WriteLine();
            Console.WriteLine(str6);

            // метод Substring: извлекает из строки подстроку, начиная с указанной позиции
            Console.WriteLine("Введите строку");
            string str7 = Console.ReadLine();
            string str8 = "";
            Console.WriteLine("Введите символ, с которого нужно скопировать строку");
            int indexStart = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество символов для копирования");
            int countIndex = Int32.Parse(Console.ReadLine());
            if (indexStart > str7.Length || countIndex > str7.Length || indexStart > countIndex)
                Console.WriteLine("ERROR");
            else
            Console.WriteLine(str8 =  str7.Substring(indexStart-1, countIndex-1));
            
            


        }





    }
}