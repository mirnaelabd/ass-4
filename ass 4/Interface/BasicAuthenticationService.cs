using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass_4.Interface
{
    public class BasicAuthenticationService : IAuthenticationService
    {
       
        private  string storedUsername = "admin";
        private  string storedPassword = "password";
        private  string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
         
            if (username == storedUsername && password == storedPassword)
            {
                return true; 
            }
            return false; 
        }

        public bool AuthorizeUser(string username, string role)
        {
           
            if (username == storedUsername && role == storedRole)
            {
                return true; 
            }
            return false; 
        }
    }

}
