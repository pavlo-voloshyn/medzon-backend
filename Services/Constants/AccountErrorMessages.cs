using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Constants
{
    public class AccountErrorMessages
    {
        public const string FailedCreate = "Something went wrong. Ensure your data is valid and try again";
        public const string InvalidUserData = "Invalid Email or Password";
        public const string UserNotFound = ". Check if you enter correct username";
        public const string IncorrectPassword = "Incorrect password";
    }
}
