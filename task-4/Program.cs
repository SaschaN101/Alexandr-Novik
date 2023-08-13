using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Homework 4 --------------");
            Console.WriteLine("------------- Task 1 a --------------");

            //"abd".ToUpper().ToArray();

            void ToUpperCase(string str)
            {
               Console.WriteLine(str.ToUpper());
            }

            string RemoveExtraWhiteSpace(string str)
            {
                return str.Trim();
            }

            string RemoveNumber(string str)
            {
                string buffer = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((char)str[i] < '0' || (char)str[i] > '9')
                        buffer += str[i];
                }
                return buffer;
            }


            string RemoveSimbol(string str)
            {
                string buffer = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((char)str[i] != '.' && (char)str[i] != ',' && (char)str[i] != '!' && (char)str[i] != '?')
                        buffer += str[i];
                }
                return buffer;
            }

            string RemoveSimbol2(string str, char chDel, char chAdd)
            {
                string buffer = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((char)str[i] == chDel)
                    {
                        buffer += chAdd;
                    }
                    else buffer += str[i];
                }
                return buffer;
            }


            var str1 = Console.ReadLine();


            Console.WriteLine(RemoveSimbol2(str1, ' ', '*'));

            string AddSimbol(string str)
            {
                string buffer = "";
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if ((char)str[i] != Char.ToUpper((char)str[i]) && (char)str[i + 1] == Char.ToUpper((char)str[i + 1]))
                        buffer += " ";
                    else buffer += str[i];
                }
                return buffer;
            }

            Console.WriteLine();
            Console.WriteLine("------------- Task 1 b  --------------");
            Console.WriteLine();


            StrDeligate removeSimbol = RemoveSimbol2;
            Console.WriteLine(removeSimbol(str1, 'e', 'a'));

            void funk1(StrDeligate strD, Func<string, string> addS) 
            {
                string str = Console.ReadLine();
                str = strD(str, 'e', 'a');
                str = addS(str);
                Console.WriteLine(str);
            };
            funk1(RemoveSimbol2, AddSimbol);

            int strLength(string str) 
            {
                return str.Length;
            };

            bool strMore(int length)
            {
                if (length > 5)
                { return true; }
                else { return false; }
            };
            bool strLess(int length)
            {
                if (length < 5)
                { return true; }
                else { return false; }
            };

            void AddA (string str)
            {
                str += 'A';
                Console.WriteLine(str);
            };

            void func2(Func<string, int> getLength, Predicate<int> checkStrMore, Predicate<int> checkStrLess,  Action<string> addSimbolA, Action<string> strUpCase) 
            {
                string str = Console.ReadLine();
                var strLengh = getLength(str);
                if (checkStrMore(strLengh))
                { addSimbolA(str); }
                else { strUpCase(str); }

            };
            Console.WriteLine("Вызов функции 2");
            func2(strLength, strMore, strLess, AddA,ToUpperCase);

                       
            Console.WriteLine("------------- Task 2 a --------------");


            Action<int, int> multLambda = (int x, int y) =>
            {
                Console.WriteLine($"{x * y}");
            };
           
            Func<int,int, int> sumLambda = (int a, int b ) => a+ b;

            Predicate<string> stringLtngthLambdaM = (string strL) =>
            {
                if (strL.Length > 10)
                { return true; }
                else { return false; }
            };

            Predicate<string> stringLtngthLambdaL = (string strL) =>
            {
                if (strL.Length < 10)
                { return true; }
                else { return false; }
            };

            Func<string, string> strAddA = (string str) => { return str + "A"; };

            Func<string, string> strToLowLamb = (string str) => { return str.ToLower(); };

            Func<string, string> strRemovBackSpace = (str) => 
            {
                string buffer = "";
                for (int i = 0; i < str.Length; i++)
                {
                    if ((char)str[i] != ' ' )
                        buffer += str[i];
                    else { buffer += ','; }
                } 
                return buffer;
            };
            strAddA(str1);

            Console.ReadLine();



        }           

    }


    delegate string StrDeligate(string str, char ch, char ch2);
        
}
