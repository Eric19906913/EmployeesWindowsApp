namespace TPFinalHaasEric;

/// <summary>
/// Dto to use in services.
/// </summary>
public record EmployeeDto
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string DNI { get; set; } = null!;

    public bool IsMarried { get; set; }

    public int Age { get; set; }

    public decimal Salary { get; set; }
}
