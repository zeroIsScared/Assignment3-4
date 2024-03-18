using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Customer : User
    {
        private readonly List<Order> CustomerOrders = new List<Order>();
        
        public Customer (string username, string password) :
            base (username, password)
        { }
        public int Id { get; set;}
        public string Email { get; set; }
        public string Address { get; set; }
        public string Payment { get; set; }

        public void AddCustomerDetails(string email, string payment)
        {
            Email = email;            
            Payment = payment;
        }
        public void AddCustomerDetails (string email, string address, string payment)
        {
            Email = email;
            Address = address;
            Payment = payment;
        }

        override public void Login (string email, string password)
        {
            if (Email is null)
            {
                Console.WriteLine("You didn't provide an email, please login with your username instead!");
            } else
            {
                if (email == Email && Password == password)
                {
                    _sessionId = $"{UserName}_session";
                    sessionIds.Add(_sessionId);

                    foreach (string session in sessionIds)
                    {
                        Console.WriteLine($"User {UserName} was loged in with sessionId {session}");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid username and password");
                }
            }            
        }
    }
}
