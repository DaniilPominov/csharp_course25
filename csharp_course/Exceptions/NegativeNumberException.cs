using System;

namespace csharp_course.Exceptions;

public class NegativeNumberException:Exception
{
        public NegativeNumberException()
        : base("Negative numbers are not allowed.")
    {
    }

    // Constructor with custom message
    public NegativeNumberException(string message)
        : base(message)
    {
    }

    // Constructor with custom message and inner exception
    public NegativeNumberException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    // Constructor with the offending value
    public NegativeNumberException(double value)
        : base($"Negative numbers are not allowed. The value {value} is negative.")
    {
    }

    // Constructor with parameter name and value
    public NegativeNumberException(string parameterName, double value)
        : base($"Negative numbers are not allowed for parameter '{parameterName}'. The value {value} is negative.")
    {
    }

}