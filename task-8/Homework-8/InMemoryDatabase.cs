using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal  class InMemoryDatabase
    {
        public static List<User> users { get; }
        static List<User> user;
        static List<Product> product;
        static List<Order> order;

        

        static InMemoryDatabase()
        { user = new List<User>()
            {
                new User ("Petr", "Petrov", "Petrovich", "Moscow"),
                new User ("Nikita", "Pupkin", "Sergeevich", "Brest")
            };
          
            
            product = new List<Product>()
            {
                new Product("bread", "Borodinski, black", 2.5),
                new Product("softdrink", "Koka-kola", 3.6)
            };


            order = new List<Order>()
            {
            };
            foreach (var item in user) 
            {
                Order newOrder = new Order(item);
                order.Add(newOrder);
                foreach (var i in product)
                { newOrder.AddProduct(i); }

            }
        }

        public static void AddUser(User newUser)
        {
            user.Add(newUser);
        }
        public static void AddProduct(Product newProduct)
        {
            product.Add(newProduct);
        }
        public static void AddOrder(Order newOrder)
        {
            order.Add(newOrder);
        }


        public List<User> showUser()
        {
            List<User>copyUsers = new List<User>(user);
            return copyUsers;
        }
        public static List<Product> showProduct()
        {
            List<Product> copyProduct = new List<Product>(product);
            return copyProduct;
        }
        public List<Order> showOrder()
        {
            List<Order> copyOrder = new List<Order>(order);
            return copyOrder;
        }
    }
}
