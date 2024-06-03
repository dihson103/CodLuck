using Microsoft.EntityFrameworkCore;
using Part5.Abstractions.Repositories;
using Part5.Entities;

namespace Part5.Repositories;

public sealed class ClassRepository(CodLuckAppDbContext _context) : IClassRepository
{
    public void Add(Class course)
    {
        _context.Classes.Add(course);
    }

    public void Delete(Class course)
    {
        _context.Classes.Remove(course);
    }

    public async Task<List<Class>> GetAll()
    {
        return await _context.Classes.AsNoTracking().ToListAsync();
    }

    public async Task<Class> GetById(int id)
    {
        return await _context.Classes.AsNoTracking().SingleOrDefaultAsync(c => c.Id == id);
    }

    public void Update(Class course)
    {
        _context.Classes.Update(course);
    }
}
