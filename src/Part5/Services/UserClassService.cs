using AutoMapper;
using Part5.Abstractions.Repositories;
using Part5.Abstractions.Services;
using Part5.Dtos.User;
using Part5.Entities;

namespace Part5.Services;

public sealed class UserClassService(
    IUserClassRepository _userClassRepository, 
    IUnitOfWork _unitOfWork,
    IMapper _mapper) : IUserClassService
{
    public async Task CreateNewUserClass(int userId, int classId)
    {
        var userClass = UserClass.Create(userId, classId);

        _userClassRepository.Add(userClass);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<List<UserResponse>> GetUsersByClassId(int classId)
    {
        var users = await _userClassRepository.GetUserClassesByClassId(classId);

        return users.ConvertAll(user => _mapper.Map<UserResponse>(user.User));
    }
}
