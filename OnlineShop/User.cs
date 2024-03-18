using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class User
    {
        protected string _sessionId;
        protected List<string> sessionIds = new List<string>();

        public User(string userName, string passWord)
        {
            UserName = userName;
            Password = passWord;
        }

        public string UserName {get;}
        public string Password {get; private set;}
        public virtual void Login (string userName, string password)
        {
            if(userName == UserName && password == Password)
            {
                _sessionId = $"{userName}_session";
                sessionIds.Add(_sessionId);

                foreach (string session in sessionIds) {
                    Console.WriteLine($"User {UserName} was loged in with sessionId {session}");
                }
                
            } else
            {
                Console.WriteLine("Please enter a valid username and password");
            }            
        }

        public void Logout ()
        {
            Console.WriteLine($"The user {UserName} was loged out");
        }
    }
}
