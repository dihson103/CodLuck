using AutoMapper;
using Part5.Dtos.User;
using Part5.Entities;

namespace Part5.Mappers;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<User, UserResponse>();
    }
}
