using PizzaApp.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaApp.Domain.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidatePassword(string password)
        {
            var passwordLenght = password.Length;
            bool digitFound = false;
            foreach (var charachter in password)
            {
                var isNumber = int.TryParse(charachter.ToString(), out int result);
                if (isNumber)
                {
                    digitFound = isNumber;
                }
            }

            if (digitFound && passwordLenght > 7)
            {
                return true;
            }
            return false;
        }

        public static bool CheckUserName(string userName,List<User> userNames)
        {
            var userNameLength = userName.Length;
            var checkIfExists = userNames.Any(u => u.UserCredentials.Username == userName);
            if (checkIfExists)
            {
                throw new ApplicationException("Sorry a user with that username exists already");
            }
            if (userNameLength < 5)
            {
                return false;
            }
            return true;
        } 
    }
}
