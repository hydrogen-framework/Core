﻿namespace Hydrogen.Core.Shared.Exceptions;

public abstract class BaseException : Exception
{
    public BaseException() : base() { }
    public BaseException(string message) : base(message) { }
}
