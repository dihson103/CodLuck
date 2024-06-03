using Part5.Dtos.User;

namespace Part5.Abstractions.Services;

public interface IUserService
{
    Task CreateNewUser(CreateUserRequest request);
    Task<List<UserResponse>> GetAllUsers();
    Task<UserResponse> GetUserById(int id);
    Task RemoveUserById(int id);
}
