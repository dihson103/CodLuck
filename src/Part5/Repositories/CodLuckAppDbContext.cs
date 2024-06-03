using Microsoft.EntityFrameworkCore;
using Part5.Abstractions.Repositories;
using Part5.Entities;

namespace Part5.Repositories;

public class CodLuckAppDbContext : DbContext, IUnitOfWork
{
    public CodLuckAppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Class> Classes { get; set; }
    public DbSet<UserClass> UserClasses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserClass>()
            .HasKey(uc => new { uc.UserId, uc.ClassId });

        modelBuilder.Entity<UserClass>()
            .HasOne(uc => uc.User)
            .WithMany(u => u.UserClasses)
            .HasForeignKey(uc => uc.UserId);

        modelBuilder.Entity<UserClass>()
            .HasOne(uc => uc.Class)
            .WithMany(c => c.UserClasses)
            .HasForeignKey(uc => uc.ClassId);

    }
}
