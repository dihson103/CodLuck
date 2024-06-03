using AutoMapper;
using Part5.Abstractions.Repositories;
using Part5.Abstractions.Services;
using Part5.Dtos.User;
using Part5.Entities;

namespace Part5.Services;

public sealed class UserService(IUserRepository _userRepository, IUnitOfWork _unitOfWork, IMapper _mapper)
    : IUserService
{
    public async Task CreateNewUser(CreateUserRequest request)
    {
        var user = User.Create(request);

        _userRepository.Add(user);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task<List<UserResponse>> GetAllUsers()
    {
        var users = await _userRepository.GetAll();

        return users.ConvertAll(user => _mapper.Map<UserResponse>(user));
    }

    public async Task<UserResponse> GetUserById(int id)
    {
        var user = await _userRepository.GetById(id);

        return _mapper.Map<UserResponse>(user);
    }

    public Task RemoveUserById(int id)
    {
        throw new NotImplementedException();
    }
}
