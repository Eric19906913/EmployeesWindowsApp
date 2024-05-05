using App.Domain;
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

    public async Task CreateEmployeeAsync(EmployeeDto employee)
    {
        try
        {
            var newEmployee = new Employee();
            newEmployee.SetFullName(employee.FullName);
            newEmployee.SetIsMarried(employee.IsMarried);
            newEmployee.SetSalary(employee.Salary);
            newEmployee.SetDni(employee.DNI);
            newEmployee.SetAge(employee.Age);

            await this.employeeRepository.CreateEmployeeAsync(newEmployee);
        }
        catch (ArgumentNullException)
        {
            throw;
        }
        catch (InvalidOperationException)
        {
            throw;
        }
        catch (Exception)
        {
            throw;
        }
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
