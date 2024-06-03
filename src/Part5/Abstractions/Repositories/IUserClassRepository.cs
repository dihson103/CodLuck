using Part5.Entities;

namespace Part5.Abstractions.Repositories;

public interface IUserClassRepository
{
    void Add(UserClass userClass);
    void Update(UserClass userClass);
    void Delete(UserClass userClass);
    Task<List<UserClass>> GetUserClassesByClassId(int classId);
    void DeleteRange(List<UserClass> userClasses);
}
