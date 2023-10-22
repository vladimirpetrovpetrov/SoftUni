using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Exceptions
{
    public class InvalidDateTimeException : Exception
    {
        private const string DefaultMessage = "Invalid DateTime format!";
        public InvalidDateTimeException()
            : base(DefaultMessage)
        {

        }

        public InvalidDateTimeException(string message)
            : base(message)
        {

        }
    }
}
