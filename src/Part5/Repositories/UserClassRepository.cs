using Microsoft.EntityFrameworkCore;
using Part5.Abstractions.Repositories;
using Part5.Entities;

namespace Part5.Repositories;

public sealed class UserClassRepository(CodLuckAppDbContext _context)
    : IUserClassRepository
{
    public void Add(UserClass userClass)
    {
        _context.UserClasses.Add(userClass);
    }

    public void Delete(UserClass userClass)
    {
        _context.UserClasses.Remove(userClass);
    }

    public void DeleteRange(List<UserClass> userClasses)
    {
        _context.UserClasses.RemoveRange(userClasses);
    }

    public async Task<List<UserClass>> GetUserClassesByClassId(int classId)
    {
        return await _context.UserClasses
            .AsNoTracking()
            .Include(uc => uc.User)
            .Where(uc => uc.ClassId == classId)
            .ToListAsync();
    }

    public void Update(UserClass userClass)
    {
        _context.UserClasses.Update(userClass);
    }
}
