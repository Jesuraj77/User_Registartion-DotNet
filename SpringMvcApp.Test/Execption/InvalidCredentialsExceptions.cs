using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.Test.Execption
{
    class InvalidCredentialsExceptions :Exception
    {
        public string Messages = "Please enter valid usename & password";

        public InvalidCredentialsExceptions(string message)
        {
            Messages = message;
        }
    }
}
