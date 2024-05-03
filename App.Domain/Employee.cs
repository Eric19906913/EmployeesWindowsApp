namespace App.Domain;

public class Employee
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;
    
    public string DNI { get; set; } = null!;

    public int Age { get; set; }

    public bool IsMarried { get; set; }

    public decimal Salary { get; set; }
}
