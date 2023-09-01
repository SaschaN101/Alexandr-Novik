using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7
{
    internal class DiscountProduct : Product
    {
        public int currentDiscount;
        
        public int CurrentDiscount 
        {
            get { return currentDiscount; }
            set {  currentDiscount = value;  }
        }
        public override double PriceOfProduct
        {
            get { return this.PriceOfProduct * (100 - currentDiscount) / 100; }
        }
        public DiscountProduct(string productName, string discriptionOfProduct, double priceOfProduct, int currentDiscount) : 
            base(productName, discriptionOfProduct, priceOfProduct)
        {
            this.CurrentDiscount = currentDiscount;
        }
    }
}
