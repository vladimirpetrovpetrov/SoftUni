
using System;

namespace LogForU.Core.Exceptions;

public class EmptyFileNameException : Exception
{
    private const string DefaultMessage = "File name can't be null or whitespace!";
    public EmptyFileNameException()
        : base(DefaultMessage)
    {

    }

    public EmptyFileNameException(string message)
        : base(message)
    {

    }
}
