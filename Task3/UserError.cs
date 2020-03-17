using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    abstract class UserError
    {
        abstract public string UEMessage();

        public string NumericInputError():  UEMessage
        {

        }


    }
    
}
