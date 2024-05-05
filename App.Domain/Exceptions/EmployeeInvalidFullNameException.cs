namespace App.Domain;

public class EmployeeInvalidFullNameException : Exception
{
    public EmployeeInvalidFullNameException(string message)
        : base(message)
    {
    }

    public EmployeeInvalidFullNameException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
