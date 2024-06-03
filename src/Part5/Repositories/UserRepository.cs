using Microsoft.EntityFrameworkCore;
using Part5.Abstractions.Repositories;
using Part5.Entities;

namespace Part5.Repositories;

public sealed class UserRepository(CodLuckAppDbContext _context) : IUserRepository
{
    public void Add(User user)
    {
        _context.Users.Add(user);
    }

    public void Delete(User user)
    {
        _context.Users.Remove(user);
    }

    public async Task<List<User>> GetAll()
    {
        return await _context.Users.AsNoTracking().ToListAsync();
    }

    public Task<User> GetById(int id)
    {
        return _context.Users.AsNoTracking().SingleOrDefaultAsync(user => user.Id == id);
    }

    public void Update(User user)
    {
        _context.Users.Update(user);
    }
}
