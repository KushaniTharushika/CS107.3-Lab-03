using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_3
{
    internal class Product
    {
        private int productId;
        private string productname;
        private double price;
        private int quantityInStock;

        public Product(int productId, string productname, double price, int quantityInStock)
        {
            this.productId = productId;
            this.productname = productname;
            this.price = price;
            this.quantityInStock = quantityInStock;
        }

        public void AddProduct()
        {
            Console.WriteLine("Product added successfully!");
        }

        public void BuyProduct()
        {
            if (this.quantityInStock > 0)
            {
                quantityInStock--;
                Console.WriteLine("Product brought successfully!");
            }
            else 
            {
                Console.WriteLine("Product out of stock!");
            }
        }

        public double Price { get { return price; } }
        public string ProductName { get { return productname; } }
        public int QuantityInStock { get { return quantityInStock; } }

    }
}
