using Part5.Dtos.User;
using System.ComponentModel.DataAnnotations;

namespace Part5.Entities;

public class User
{
    [Required]
    public int Id { get; private set; }
    [Required]
    public string Name { get; private set; }
    [Required]
    public string Email { get; private set; }
    [Required]
    public string Password { get; private set; }
    public string Address { get; private set; }
    public List<UserClass> UserClasses { get; private set; }
    private User()
    {
    }

    public static User Create(CreateUserRequest request)
    {
        return new()
        {
            Address = request.Address,
            Password = request.Password,
            Name = request.Name,
            Email = request.Email,
        };
    }
}
