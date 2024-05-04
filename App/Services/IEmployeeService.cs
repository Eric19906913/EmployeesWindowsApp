namespace TPFinalHaasEric.Services;

public interface IEmployeeService
{
    public Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();

    public Task DeleteEmployee(int id);
}
