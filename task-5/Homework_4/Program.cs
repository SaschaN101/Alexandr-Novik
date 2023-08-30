using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Homework 5 --------------");
            Console.WriteLine("------------- Task 1 Exception --------------");



            try 
            {
              Console.WriteLine("Введите строку");
                string _str =  Console.ReadLine();

               


                if (_str.Length > 3)
                {
                    throw new MeException("Длина строки болеее 4 символов!!!");
                }
                
              
            } 
            catch(MeException error)
            {

                    Console.WriteLine(error.Message);
            }

            try
            {
                int x = 10;
                int y = 0;
               Console.WriteLine(x/y);
                                
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

           void Sum(int a, int b)
           {
                Console.WriteLine(a + b); 
           }
            void checkObj(object a)
            {
                if (a == null)
                {
                    throw new ArgumentException("Cannot be null");
                }
            }
            
            try
            {
               Sum(1, 2);
                checkObj(null);
                
            }
            catch (ArgumentException error) { Console.WriteLine(error.Message); }
            catch (Exception error) { Console.WriteLine(error.Message); }
          

            try
            {
                int[] numbers = new int[4];
                numbers[5] = 9;                   
            }
           
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }







            Console.ReadLine();
                      
        }
    }
}
