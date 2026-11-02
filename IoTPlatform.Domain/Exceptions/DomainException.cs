namespace IoTPlatform.Domain.Exceptions;

/// <summary>
/// This is a custom exception used to report violations of business 
/// rules within the IoT platform.
/// 
/// For example, this exception can be thrown when:
/// - A serial number doesn't follow the required format.
/// - A device is being transitioned to an invalid status.
/// - An alert rule is being configured with an invalid operating range.
/// </summary>
public class DomainException : Exception
{
    /// <summary>
    /// Calling this constructor initializes a new instance of the 
    /// DomainException class with a specified error message. The 
    /// message should describe the specific business rule violation 
    /// that occurred.
    /// </summary>
    /// <param name="message">
    /// The error message describing the business rule violation.
    /// </param>
    public DomainException(string message)
        : base(message)
    {
    }
}