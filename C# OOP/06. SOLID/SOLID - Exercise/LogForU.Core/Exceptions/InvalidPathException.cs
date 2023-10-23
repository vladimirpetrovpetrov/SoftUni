using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Exceptions;

public class InvalidPathException : Exception
{
    private const string DefaultMessage = "Invalid path or is empty!";
    public InvalidPathException()
        : base(DefaultMessage)
    {

    }

    public InvalidPathException(string message)
        : base(message)
    {

    }
}
