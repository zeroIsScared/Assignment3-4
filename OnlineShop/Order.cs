using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Order 
    {   
        private readonly List<Product> OrderedItems = new List<Product>();
        
        public Order(int customerId)
        {
            CustomerId = customerId;
        }
        public int OrderId { get; private set; }  
        public int CustomerId { get; }            

        public void AddProduct (Product product, bool onSale = false)
        {
            bool useDiscount = onSale;
            OrderedItems.Add(product);
            Console.WriteLine($"The product was added to your order, an discount is available = {useDiscount}." +
                $" Your order has {OrderedItems.Count} products.");
        }           

    }
}
