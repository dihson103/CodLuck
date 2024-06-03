using Part5.Dtos.User;

namespace Part5.Abstractions.Services;

public interface IUserClassService
{
    Task CreateNewUserClass(int userId, int classId);
    Task<List<UserResponse>> GetUsersByClassId(int classId);
}
