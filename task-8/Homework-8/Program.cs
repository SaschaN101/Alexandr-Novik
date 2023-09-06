using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User petrov = new User("Petr", "Petrov", "Petrovich", "Moscow");
            User pupkin = new User("Nikita", "Pupkin", "Sergeevich", "Brest");
            Product bread = new Product("bread", "Borodinski, black", 2.5);
            Product soda = new Product("softdrink", "Koka-kola", 3.6);
            Order petrovOrder = new Order(petrov);
            Order ppupkinOrder = new Order(pupkin);
            petrovOrder.AddProduct(bread);
            ppupkinOrder.AddProduct(soda);
            petrovOrder.AddProduct(soda);
            Console.WriteLine(petrovOrder.SumPrice());
            Console.WriteLine(petrovOrder.ToString());
            petrovOrder.RemoveProduct(bread);
            Console.WriteLine(petrovOrder.SumPrice());
            Console.WriteLine(petrovOrder.ToString());
            Console.WriteLine(petrov.ToString());

            Product bread1 = new Product("bread", "Narochanski, black", 2.3);
            petrovOrder.AddProduct(bread1);
            Console.WriteLine("Сумма без скидки = " + petrovOrder.SumPrice() + " " + petrovOrder.ToString());
            petrovOrder.RemoveProduct(bread1);
            DiscountProduct bread2 = new DiscountProduct("bread", "Narochanski, black", 2.3, 15);
            petrovOrder.AddProduct(bread2);
            Console.WriteLine(petrovOrder.ToString());
            Console.WriteLine(petrovOrder.SumPrice());
            Console.WriteLine(bread2.Equals(bread2));
            Console.WriteLine(bread1.Equals(bread2)); // True !!!!!
            Console.WriteLine(bread1.Equals(bread));
            Console.WriteLine(User.counter);
            string a = "+3754410101j2";
            Console.WriteLine(PhoneHelper.IsPhoneValid(a));
            Console.ReadLine();
        }
    }
}
