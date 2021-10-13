using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace Assignment1DNP.Data
{
    public class InMomeryUserService: IUserService
    {
        private List<User> users;

        public InMomeryUserService()
        {
            users = new[]
            {
                new User
                {
                    Username = "alina",
                    Password = "1234",
                    Age = 34,
                    SecurityLevel = 3
                },
                new User
                {
                    Username = "teo",
                    Password = "4321",
                    Age = 25,
                    SecurityLevel = 1
                }
            }.ToList();
        }
        public User ValidateUser(string username, string password)
        {
            User first = users.FirstOrDefault(user => user.Username.Equals(username));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }  
       /* public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }*/
    }
}