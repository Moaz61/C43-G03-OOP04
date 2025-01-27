using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ass5OOP.Interfaces;

namespace Ass5OOP.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            return username == "admin" && password == "pass1234";
        }

        public bool AuthorizeUser(string username, string role)
        {
           return username == "admin" && role == "Administrator";
        }
    }
}
