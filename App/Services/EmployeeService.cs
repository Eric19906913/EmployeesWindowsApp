using App.Persistence;
using AutoMapper;
using TPFinalHaasEric.Services;

namespace TPFinalHaasEric;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly IMapper mapper;

    public EmployeeService(
        IEmployeeRepository employeeRepository,
        IMapper mapper)
    {
        this.employeeRepository = employeeRepository;
        this.mapper = mapper;
    }

    public async Task DeleteEmployee(int id)
    {
        await this.employeeRepository.DeleteEmployeeAsync(id);
    }

    public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
    {
        var employees = await this.employeeRepository.GetAllEmployeesAsync();

        return mapper.Map<IEnumerable<EmployeeDto>>(employees);
    }
}
