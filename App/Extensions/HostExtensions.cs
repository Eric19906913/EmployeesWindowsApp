using App.Domain;
using App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TPFinalHaasEric.Extensions;

public static class HostExtensions
{
    public static async Task RunMigrationsAsync(this IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            Console.WriteLine("Corriendo migrations existentes...");
            var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();

            await dbContext.Database.MigrateAsync();
            Console.WriteLine("Migrations aplicadas exitosamente...");
            Task.Delay(1000).Wait();
            Console.Clear();
        }
    }

    public static async Task SeedInitialData(this IHost host)
    {
        using (var scope = host.Services.CreateScope())
        {
            var repository = scope.ServiceProvider.GetRequiredService<IEmployeeRepository>();

            // If there is employees seeded don't seed them again.
            if ((await repository.GetAllEmployeesAsync()).Any())
            {
                return;
            }

            await repository.CreateEmployeeAsync(
                new Employee()
                {
                    FullName = "Maximo",
                    Age = 28,
                    DNI = "1231233",
                    IsMarried = true,
                    Salary = 12,
                });
        }
    }
}
