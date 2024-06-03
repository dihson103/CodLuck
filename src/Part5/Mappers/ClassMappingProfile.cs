using AutoMapper;
using Part5.Dtos.Class;
using Part5.Entities;

namespace Part5.Mappers;

public class ClassMappingProfile : Profile
{
    public ClassMappingProfile()
    {
        CreateMap<Class, ClassResponse>();
    }
}
