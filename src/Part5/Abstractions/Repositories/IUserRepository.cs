using Part5.Entities;

namespace Part5.Abstractions.Repositories;

public interface IUserRepository
{
    void Add(User user);
    void Update(User user);
    void Delete(User user);
    Task<User> GetById(int id);
    Task<List<User>> GetAll();
}
