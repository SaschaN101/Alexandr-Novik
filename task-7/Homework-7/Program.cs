using System;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            User petrov = new User(4, "Petr","Petrov","Petrovich", "Moscow");
            User pupkin = new User(4, "Nikita", "Pupkin", "Sergeevich", "Brest");
            Product bread = new Product("bread", "Borodinski, black", 2.5);
            Product soda = new Product("softdrink", "Koka-kola", 3.6);
            Order petrovOrder = new Order(3, petrov);
            Order ppupkinOrder = new Order(4, pupkin);
            petrovOrder.AddProduct(bread);
            ppupkinOrder.AddProduct(soda);
            petrovOrder.AddProduct(soda);
            Console.WriteLine(petrovOrder.SumPrice());
            Console.WriteLine(petrovOrder.ToString());
            petrovOrder.RemoveProduct(bread);
            Console.WriteLine(petrovOrder.SumPrice());
            Console.WriteLine(petrovOrder.ToString());
            Console.WriteLine(petrov.ToString());


            DiscountProduct bread2 = new DiscountProduct("bread", "Narochanski, black", 2.3, 15);
            
            
            petrovOrder.AddProduct(bread2);
            Console.WriteLine(petrovOrder.ToString());
            

            Console.ReadLine();
        }
    }
}