namespace App.Domain;

public class EmployeeInvalidDniException : Exception
{
    public EmployeeInvalidDniException(string message)
        : base(message)
    {
    }

    public EmployeeInvalidDniException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
