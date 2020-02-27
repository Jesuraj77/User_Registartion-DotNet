using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.Test.Execption
{
    class UserNotApprovalsException : Exception
    {
        public string Messages = "User has not accepted your admin request";

        public UserNotApprovalsException(string message)
        {
            Messages = message;
        }
    }
}
