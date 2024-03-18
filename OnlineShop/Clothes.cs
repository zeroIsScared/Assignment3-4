using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    class Clothes : Product
    {
        public Clothes (string name):
            base (name)
        {
            Name = name;
        }
        public string Size { get; set; }
        public bool CanBeTriedOn { get; set; }

        public void TryOn()
        {
            Console.WriteLine($"The customer tried on {Name}  item.");
        }

        override public void UpdateProductStock(int soldProducts)
        {
            if (ItemsInStock >= soldProducts)
            {
                ItemsInStock -= soldProducts;
            }
            else
            {
                Console.WriteLine($"This clothing item stock is less than {soldProducts}");
            }
        }

        public void AddProductToSale(int discount, string promotionCampainName)
        {
            Console.WriteLine($"Product {Name} is on discount {discount}% as part of {promotionCampainName}.");
        }

    }
}
