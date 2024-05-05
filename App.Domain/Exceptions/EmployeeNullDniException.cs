namespace App.Domain;

public class EmployeeNullDniException : Exception
{
    public EmployeeNullDniException(string message)
        : base(message)
    {
    }

    public EmployeeNullDniException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
