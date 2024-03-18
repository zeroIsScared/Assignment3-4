using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Product
    {
        public Product(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Price { get; set; }
        public bool IsAvailable { get; set; }

        public int ItemsInStock { get; set; }

        public virtual void UpdateProductStock (int soldProducts)
        {
            if( ItemsInStock >= soldProducts)
            {
                ItemsInStock -= soldProducts;
            } else
            {
                Console.WriteLine($"The product stock is less than {soldProducts}");
            }
        }   
        
        public void AddProductToSale(int discount)
        {
            Console.WriteLine($"Product {Name} is on discount {discount}%.");
        }
    }
}
