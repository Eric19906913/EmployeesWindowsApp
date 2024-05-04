using App.Domain;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly AppDbContext dbContext;

    public EmployeeRepository(
        AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task CreateEmployeeAsync(Employee employee)
    {
        await this.dbContext.AddAsync(employee);
        await this.SaveChangesAsync();
    }

    public async Task DeleteEmployeeAsync(int id)
    {
        try
        {
            var employee = await this.dbContext.Employees.FirstAsync(x => x.Id == id);
            this.dbContext.Remove(employee);
            await this.SaveChangesAsync();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
    {
        return await this.dbContext.Employees.ToListAsync();
    }

    public async Task UpdateEmployeeAsync(int id, Employee newEmployee)
    {
        try
        {
            var employee = await this.dbContext.Employees.FirstAsync(x => x.Id == id);

            employee.FullName = newEmployee.FullName;
            employee.Age = newEmployee.Age;
            employee.Salary = newEmployee.Salary;
            employee.DNI = newEmployee.DNI;
            employee.IsMarried = newEmployee.IsMarried;

            this.dbContext.Update(employee);
            await this.SaveChangesAsync();
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
            throw;
        }
    }

    private async Task<bool> SaveChangesAsync()
    {
        return await this.dbContext.SaveChangesAsync() > 0;
    }
}
