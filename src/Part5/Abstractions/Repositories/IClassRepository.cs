using Part5.Entities;

namespace Part5.Abstractions.Repositories;

public interface IClassRepository
{
    void Add(Class course);
    void Update(Class course);
    void Delete(Class course);
    Task<Class> GetById(int id);
    Task<List<Class>> GetAll();
    
}
