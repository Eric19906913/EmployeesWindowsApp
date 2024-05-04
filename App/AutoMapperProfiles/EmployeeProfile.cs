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
    }
}
