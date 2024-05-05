namespace App.Domain;

public class Employee
{
    public int Id { get; set; }

    public string FullName { get; private set; } = null!;
    
    public string DNI { get; private set; } = null!;

    public int Age { get; private set; }

    public bool IsMarried { get; private set; }

    public decimal Salary { get; private set; }

    public void SetFullName(string fullName)
    {
        if (fullName is null || fullName == string.Empty)
        {
            throw new EmployeeNullFullNameException("El nombre del empleado no puede estar vacio.");
        }

        if (fullName.Length > EmployeeConstants.EmployeeFullNameMaxLength)
        {
            throw new EmployeeInvalidFullNameException($"El nombre del empleado acepta un maximo de {EmployeeConstants.EmployeeFullNameMaxLength}, usted ingreso {fullName.Length}");
        }

        this.FullName = fullName;
    }

    public void SetDni(string dni)
    {
        if (dni is null || dni == string.Empty)
        {
            throw new EmployeeNullDniException("El dni del empleado no puede estar vacio.");
        }

        if (dni.Length > EmployeeConstants.EmployeeDniMaxLength)
        {
            throw new EmployeeInvalidDniException($"El maximo de caracteres aceptados para el dni es de {EmployeeConstants.EmployeeDniMaxLength}, usted ingreso {dni.Length}");
        }

        this.DNI = dni;
    }

    public void SetAge(int age)
    {
        if (age < 1)
        {
            throw new EmployeeInvalidAgeException("La edad del empleado debe ser mayor a cero");
        }

        this.Age = age;
    }

    public void SetIsMarried(bool isMarried)
    {
        this.IsMarried = isMarried;
    }

    public void SetSalary(decimal salary)
    {
        if (salary < 0)
        {
            throw new EmployeeInvalidSalaryException("El salario del empleado debe ser mayor a cero.");
        }

        this.Salary = salary;
    }
}
