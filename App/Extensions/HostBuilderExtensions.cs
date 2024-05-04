using App.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TPFinalHaasEric.Services;

namespace TPFinalHaasEric.Extensions;

public static class HostBuilderExtensions
{
    /// <summary>
    /// Configure all the services needed by our Application
    /// </summary>
    /// <param name="builder">The Host builder.</param>
    /// <returns>The builder itself for chaining.</returns>
    public static IHostBuilder ConfigureApplicationServices(this IHostBuilder builder)
    {
        // Configure our required services here so we don't have
        // to do it in Program.
        builder.ConfigureServices(services => 
        {
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddAutoMapper(opts => opts.AddProfile<EmployeeProfile>());
            services.AddTransient<EmployeeView>();
            services.AddDbContext<AppDbContext>(
                opts => opts.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=TpFinalHaasEric;Trusted_Connection=True;MultipleActiveResultSets=true"));
        });
        
        return builder;
    }
}
