namespace App.Domain;

internal class EmployeeInvalidSalaryException : Exception
{
    public EmployeeInvalidSalaryException(string message)
        : base(message)
    {
    }

    public EmployeeInvalidSalaryException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
