using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order1 = new Order(1, "Иван", "Иванов", "Иванович", "г.Минск, ул. Красивая", "Молоко", "Брест-литовское, 3,6 %", 2.8, 3);
            var order2 = new Order(2, "Александр", "Александров", "Александрович", "г.Минск, ул. Ясная", "сельдь", "Матиас", 5.8, 2);
            var order3 = new Order("Сидр", "Сидоров", "огурец", 3);
            Console.WriteLine(Equals(order1, order2)); // сравнение объектов
            Console.WriteLine(Equals(order3, order2));
            Console.WriteLine(order1.GetType()); // проверка типа созданного объекта
            List<Order> orders = new List<Order>();
            orders.Add(order1);
            orders.Add(order2);
            orders.Add(order3);
            Console.WriteLine(order1.FirstNameCustomer + " " + order1.ProductName);
            Order[] arrayOrders = new Order[] { order1, order2, order3 };
            // Отсортировать массив по возрастанию полной стоимости заказа. 

            Console.ReadLine();
        }
    }

}
