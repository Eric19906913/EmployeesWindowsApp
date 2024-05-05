using App.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence;

public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FullName)
            .HasMaxLength(EmployeeConstants.EmployeeFullNameMaxLength);

        builder.Property(x => x.IsMarried);

        builder.Property(x => x.Salary)
            .HasPrecision(10, 2);

        builder.Property(x => x.DNI)
            .HasMaxLength(EmployeeConstants.EmployeeDniMaxLength);

        builder.Property(x => x.Age);
    }
}
