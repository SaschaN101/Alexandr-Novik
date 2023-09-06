using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    internal class Product : BaseModel
    {
        string productName;
        string discriptionOfProduct;
        double priceOfProduct;

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
        public virtual double PriceOfProduct
        {
            get => priceOfProduct;
            set { if (value > 0) priceOfProduct = value; }
        }
        public Product(string productName, string discriptionOfProduct, double priceOfProduct)
        {
            this.ProductName = productName;
            this.DiscriptionOfProduct = discriptionOfProduct;
            this.PriceOfProduct = priceOfProduct;
        }
        public override string ToString()
        {
            return $"{productName} {discriptionOfProduct} {priceOfProduct} ";
        }
        public override bool Equals(object prod)
        {
            Product _prod = (Product)prod;
            bool x = this.productName == _prod.productName && this.discriptionOfProduct == _prod.discriptionOfProduct && this.productName == _prod.productName;
            return x;
        }

        public override int GetHashCode()
        {
            return productName.GetHashCode() + discriptionOfProduct.GetHashCode() + priceOfProduct.GetHashCode();
        }
    }
}
