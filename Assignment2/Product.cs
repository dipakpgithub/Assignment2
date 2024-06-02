using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    // Producat class
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }


        public Product(int productId, string productName, decimal price, int stock) => (ProductId, ProductName, Price, Stock) = (productId, productName, price, stock);


        // Method for Increase stock
        public void IncreaseStock(int amount)
        {
            if (amount > 0) Stock += amount;

        }
        // Method for descrease stock
        public void DecreaseStock(int amount)
        {
            if (amount > 0 && amount <= Stock) Stock -= amount;

        }

    }
}