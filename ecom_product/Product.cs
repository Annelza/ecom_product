using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecom_product
{
    public class Product
    {
        public char productID;
        public string productName;
        public int stock;
        public double price;

        public Product(char productID)
        {
            this.productID = productID;
        }

        public Product(string productName)
        {
            this.productName = productName;
        }

        public Product(double price)
        {
            this.price = price;
        }

        public Product(int stock)
        {
            this.stock = stock;
        }

        public int StockIncrease(int value)
        {
            int st;
            st = stock + value;
            return st;
        }

        public int StockDecrease(int value)
        {
            int st;
            st = stock - value;
            return st;
        }
    }
}


