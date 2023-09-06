using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal interface IDatabase
    {
         void AddUser(User newUser);
         void AddProduct(Product newProduct);
         void AddOrder(Order newOrder);


         List<User> showUser();
         List<Product> showProduct();
         List<Order> showOrder();
    }
}
