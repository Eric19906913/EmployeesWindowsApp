using App.Persistence;
using TPFinalHaasEric.Services;

namespace TPFinalHaasEric;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;

    public EmployeeService(
        IEmployeeRepository employeeRepository)
    {
        this.employeeRepository = employeeRepository;
    }

    public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
    {
        var employees = await this.employeeRepository.GetAllEmployeesAsync();

        return new List<EmployeeDto>();
    }
}
