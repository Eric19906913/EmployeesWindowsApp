using App.Domain;

namespace App.Persistence;

public interface IEmployeeRepository
{
    public Task CreateEmployeeAsync(Employee employee);

    public Task UpdateEmployeeAsync(int id, Employee newEmployee);

    public Task DeleteEmployeeAsync(int id);

    public Task<IEnumerable<Employee>> GetAllEmployeesAsync();
}
