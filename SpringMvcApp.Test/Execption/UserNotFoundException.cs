using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.Test.Execption
{
    class UserNotFoundException :Exception
    {
        public string Messages = "User Not Found Exception";
        public UserNotFoundException(string message)
        {
            Messages = message;
        }
    }
}
