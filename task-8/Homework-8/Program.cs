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
           InMemoryDatabase dataBase = new InMemoryDatabase();
            var ourUsers = dataBase.showUser();
            foreach (var user in ourUsers) 
            {
                Console.WriteLine(user.ToString());
            }
            Console.WriteLine();

            var ourProducts = InMemoryDatabase.showProduct();
            for (int i = 0; i < ourProducts.Count(); i++)
            {
                Console.WriteLine(ourProducts[i].ToString());
            }
            Console.WriteLine();

            List<Order> ourOrder = dataBase.showOrder();
            foreach (var order in ourOrder)
            {
                Console.WriteLine(order.ToString());
            }
           

            while (true) 
            {
                string comand = Console.ReadLine();
                if (comand == "addUser")
                {
                    Console.WriteLine("Введите фамилию");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Введите имя");
                    string name = Console.ReadLine();
                    InMemoryDatabase.AddUser(new User(lastName, name));
                }
                if (comand == "addProduct")
                {
                    Console.WriteLine("Введите название продукта");
                    string productName = Console.ReadLine();
                    Console.WriteLine("Введите описание продукта");
                    string productDiscription = Console.ReadLine();
                    Console.WriteLine("Введите стоимость продукта");
                    double productPrise;
                    bool result = double.TryParse( Console.ReadLine(), out productPrise);
                    if (result) { InMemoryDatabase.AddProduct(new Product(productName, productDiscription, productPrise)); } else { Console.WriteLine("Стоимость продукта не введена"); }
                   
                }
                if (comand == "addOrder")
                {
                    Console.WriteLine("Введите Ваш ID");
                    int ourId = int.Parse(Console.ReadLine());
                    User aaaaa = dataBase.showUser().FirstOrDefault(User => User.id == ourId);
                    var ourNewOrder = new Order(aaaaa);
                    Console.WriteLine("Вы можете выбрать товар из списка");
                    int productId = int.Parse(Console.ReadLine());
                    Product product = InMemoryDatabase.showProduct().FirstOrDefault(Product => Product.id == productId);
                    ourNewOrder.AddProduct(product);
                }
                else if (comand == "exit")
                {
                    return;
                }
            }



            Console.WriteLine();



            /* User petrov = new User("Petr", "Petrov", "Petrovich", "Moscow");
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
             Console.WriteLine(PhoneHelper.IsPhoneValid(a));*/
            Console.ReadLine();
        }
    }
}
