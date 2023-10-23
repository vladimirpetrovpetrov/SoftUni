using System;

namespace LogForU.Core.Exceptions;

public class EmptyFileExtensionException : Exception
{
    private const string DefaultMessage = "File extension can't be null or whitespace!";
    public EmptyFileExtensionException()
        : base(DefaultMessage)
    {

    }

    public EmptyFileExtensionException(string message)
        : base(message)
    {

    }
}
