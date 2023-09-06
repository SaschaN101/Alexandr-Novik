using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Order : BaseModel
    {       
        int id;
        double priceOfProduct;
        int countProduct;
        User user;
        List<Product> products;

       public int Id 
        {
            get { return id; }
        }
        public double PriceOfProduct
        {
            get { return priceOfProduct; }
            set { if (priceOfProduct > 0) { priceOfProduct = value; } }
        }
        public int CountProduct
        {
            get { return countProduct; }
            set { if (value > 0) { countProduct = value; } }
        }
        public User User
        {
            get { return user; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }
        public double SumPrice()
        {
            double tonalPrice = 0;
            for (int i = 0; i < products.Count; i++)

            {
                double _price = products[i].PriceOfProduct;
                tonalPrice += _price;

            }
            return tonalPrice;
        }
        public Order(User user)
        {
            this.user = user;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public override string ToString()
        {
            string result;
            result = user.ToString() + " купил ";

            for (int i = 0; i < products.Count; i++)
            {
                result += products[i].ToString();
            }
            return result;
        }
    }
}
