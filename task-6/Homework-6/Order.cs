using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    public class Order
    {
        int id;
        string firstNameCustomer;
        string lastNameCustomer;
        string surnameCustomer;
        string adressCustomer;
        string productName;
        string discriptionOfProduct;
        double priceOfProduct;
        int countProduct;

        public int Id
        {
            get { return id; }
        }
        public string FirstNameCustomer
        {
            get { return firstNameCustomer; }
            set { if (!string.IsNullOrEmpty(value)) firstNameCustomer = value; }
        }
        public string LastNameCustomer
        {
            get { return lastNameCustomer; }
            set { if (!string.IsNullOrEmpty(value)) lastNameCustomer = value; }
        }
        public string SurnameCustomer
        {
            get => surnameCustomer;
            set => surnameCustomer = value;
        }
        public string AdressCustomer
        {
            get => adressCustomer;
            set { if (!string.IsNullOrEmpty(value)) adressCustomer = value; }
        }
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public string DiscriptionOfProduct
        {
            get { return discriptionOfProduct; }
            set { discriptionOfProduct = value; }
        }
        public double PriceOfProduct
        {
            get => priceOfProduct;
            set { if (value > 0) priceOfProduct = value; }
        }
        public int CountProduct
        {
            get { return countProduct; }
            set { if (value > 0) countProduct = value; }
        }
        public Order(int id, string firstNameCustomer, string lastNameCustomer, string surnameCustomer, string adressCustomer, string productName, string discriptionOfProduct, double priceOfProduct, int countProduct)
        {
            this.id = id;
            this.firstNameCustomer = firstNameCustomer;
            this.lastNameCustomer = lastNameCustomer;
            SurnameCustomer = surnameCustomer;
            this.adressCustomer = adressCustomer;
            this.productName = productName;
            this.discriptionOfProduct = discriptionOfProduct;
            this.priceOfProduct = priceOfProduct;
            this.countProduct = countProduct;
        }
        public Order(string firstNfmeCustomer, string lastNameCustomer, string productName, double priceOfProduct)
        {
            this.firstNameCustomer = firstNfmeCustomer;
            this.lastNameCustomer = lastNameCustomer;
            this.productName = productName;
            this.priceOfProduct = priceOfProduct;
        }
        public double SumProduct(double price, int count)
        {
            return price * count;
        }

    }
}
