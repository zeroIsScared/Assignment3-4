using System;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new User("craig", "1111");
            newUser.Login("craig", "0000");
            newUser.Login("craig", "1111");
            newUser.Logout();

            var newCustomer = new Customer("ana", "2222");
            newCustomer.Login(password: "2222", email: "ana@gmial.com");
            newCustomer.Email = "ana@gmial.com";
            newCustomer.Login("ana@gmial.com", "2222");
            newCustomer.Id = 1;

            var product1 = new Clothes("Shirt");
            var order1 = new Order(1);
            order1.AddProduct(product1);

            var firstShirt = product1 as Clothes;
            bool isProduct = firstShirt is Product;

            Console.WriteLine(firstShirt.Name);
            Console.WriteLine(isProduct);
        }
    }
}
