using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- Homework 3 ----------");
            Console.WriteLine("--------- Task 2 ----------");
            Console.WriteLine("--------- a ----------");
            void printList<T>(List<T> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i].ToString() + " ");
                }
                Console.WriteLine();
            }
            List<int> listInt = new List<int>() { 1, 2, 3 };
            printList(listInt);
            listInt.Add(4);
            printList(listInt);


            Console.WriteLine(listInt[0]);

            listInt.Clear();
            printList(listInt);

            Console.WriteLine("stack");

            void printStack(Stack<int> stack)
            {
                foreach (var item in stack)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }

            Stack<int> stackInt = new Stack<int>();
            stackInt.Push(5);
            stackInt.Push(6);
            stackInt.Push(7);
            printStack(stackInt);

            List<int> listInt2 = new List<int> { 1, 2, 3 };
            Stack<int> stackInt2 = new Stack<int>(listInt2);
            printStack(stackInt2);
            Console.WriteLine("pop: " + stackInt.Pop());
            printStack(stackInt);

            Console.WriteLine("peek: " + stackInt2.Peek());
            printStack(stackInt2);
            stackInt.Clear();
            printStack(stackInt);

            Console.WriteLine("Dictionary");
            void printDictionary(Dictionary<int, string> dictionary)
            {
                foreach (var item in dictionary)
                {
                    Console.WriteLine(item.Key + ": " + item.Value);
                }
                Console.WriteLine();
            }
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>() { { 1, "One" }, { 2, "Two" }, { 3, "Three" } };
            printDictionary(dictionary1);
            Console.WriteLine(dictionary1[1]);
            dictionary1.Add(5, "five");
            printDictionary(dictionary1);
            dictionary1.Clear();
            printDictionary(dictionary1);

            Console.WriteLine("--------- b ----------");
            List<List<int>> matrix = new List<List<int>>() { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 }, new List<int> { 7, 8, 9 } };
            matrix.Add(new List<int> { 2, 5, 8 });

            foreach (var item in matrix)
            {
                printList(item);
            }

            Console.WriteLine("--------- Task 3 ----------");
            Console.WriteLine("--------- a ----------");

            string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };
            IEnumerable<string> lengthMonthN = from month in months where month.Length == 5 select month;
            void print(IEnumerable<string> data)
            {
                foreach (var item in data)
                {
                    Console.Write(item + "  ");
                }
                Console.WriteLine();
            }
            print(lengthMonthN);

            Dictionary<string, List<string>> seasonOfYear = new Dictionary<string, List<string>>() {{"winter", new List<string> { "january", "february", "december" } },
                    {"spring", new List<string> { "march", "april", "may" } }, {"summer",  new List<string>{ "june", "july", "august" } }, {"autumn",new List<string>{ "september", "october", "november" } } };


            

            var winterSummerMonths = from season in seasonOfYear where season.Key == "winter" || season.Key == "summer" select season.Value;
           
            foreach (var item in winterSummerMonths)
            {
                printList(item);
            }

            var alphabetMonth = from month in months orderby month select month;
            print(alphabetMonth);

            var someMonts = from month in months where month.Contains("u") && month.Length > 3 select month;
            var countSomeMonths = (from month in months where month.Contains("u") && month.Length > 3 select month).Count();
            print(someMonts);
            Console.WriteLine(countSomeMonths);
            
            Console.WriteLine("--------- b ----------");


            Console.ReadLine();


        }
    }
}
