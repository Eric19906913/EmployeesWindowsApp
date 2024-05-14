namespace TPFinalHaasEric.Services;

public interface IEmployeeService
{
    public Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();

    public Task DeleteEmployee(int id);

    public Task CreateEmployeeAsync(EmployeeDto employee);

    public Task UpdateEmployeeAsync(EmployeeDto employee);
}
