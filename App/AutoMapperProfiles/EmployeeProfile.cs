using App.Domain;
using AutoMapper;

namespace TPFinalHaasEric;

public class EmployeeProfile : Profile
{
    public EmployeeProfile()
    {
        this.CreateMap<EmployeeDto, Employee>()
            .ForMember(dto => dto.Id, b => b.MapFrom(entity => entity.Id))
            .ForMember(dto => dto.FullName, b => b.MapFrom(entity => entity.FullName))
            .ForMember(dto => dto.DNI, b => b.MapFrom(entity => entity.DNI))
            .ForMember(dto => dto.IsMarried, b => b.MapFrom(entity => entity.IsMarried))
            .ForMember(dto => dto.Age, b => b.MapFrom(entity => entity.Age))
            .ForMember(dto => dto.Salary, b => b.MapFrom(entity => entity.Salary));

        this.CreateMap<Employee, EmployeeDto>()
            .ForMember(entity => entity.Id, b => b.MapFrom(dto => dto.Id))
            .ForMember(entity => entity.FullName, b => b.MapFrom(dto => dto.FullName))
            .ForMember(entity => entity.DNI, b => b.MapFrom(dto => dto.DNI))
            .ForMember(entity => entity.IsMarried, b => b.MapFrom(dto => dto.IsMarried))
            .ForMember(entity => entity.Age, b => b.MapFrom(dto => dto.Age))
            .ForMember(entity => entity.Salary, b => b.MapFrom(dto => dto.Salary));
    }
}
