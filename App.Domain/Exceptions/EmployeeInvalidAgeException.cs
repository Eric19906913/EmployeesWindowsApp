namespace App.Domain;

public class EmployeeInvalidAgeException : Exception
{
    public EmployeeInvalidAgeException(string message)
        : base(message)
    { 
    }

    public EmployeeInvalidAgeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
