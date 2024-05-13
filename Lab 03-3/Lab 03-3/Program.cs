using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product products = new Product(101,"Laptop",800,10);

            Console.WriteLine("Product Name: " + products.ProductName);
            Console.WriteLine("Price: $" + products.Price);
            Console.WriteLine("Quantity in stock: " + products.QuantityInStock);
           
            products.BuyProduct();

            Console.ReadLine();
        }
    }
}
