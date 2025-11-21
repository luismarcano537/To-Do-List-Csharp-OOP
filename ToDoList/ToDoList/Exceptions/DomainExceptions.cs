using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Exceptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
