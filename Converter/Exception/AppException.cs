namespace Converter.Exception;

[Serializable]
public class AppException : System.Exception
{
    public AppException() { }
    public AppException(string message) : base(message) { }
    public AppException(string message, System.Exception inner) : base(message, inner) { }
    protected AppException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

public class NotNumeralRomanException : AppException
{
    public NotNumeralRomanException() { }
    public NotNumeralRomanException(string message) : base(message) { }
    public NotNumeralRomanException(string message, System.Exception inner) : base(message, inner) { }
    protected NotNumeralRomanException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}

public class InvalidNumeralRomanException : AppException
{
    public InvalidNumeralRomanException() { }
    public InvalidNumeralRomanException(string message) : base(message) { }
    public InvalidNumeralRomanException(string message, System.Exception inner) : base(message, inner) { }
    protected InvalidNumeralRomanException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}