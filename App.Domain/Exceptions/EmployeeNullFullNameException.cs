namespace App.Domain;

public class EmployeeNullFullNameException : Exception
{
    public EmployeeNullFullNameException(string message)
        : base(message)
    {
    }

    public EmployeeNullFullNameException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
