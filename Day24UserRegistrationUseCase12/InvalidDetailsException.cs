using System;
using System.Collections.Generic;
using System.Text;

namespace Day24UserRegistrationUseCase12
{
    public class InvalidDetailsException:Exception
    {
        public InvalidDetailsException(string msg) : base(msg)
        {

        }
    }
}
