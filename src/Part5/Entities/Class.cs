using Part5.Dtos.Class;
using System.ComponentModel.DataAnnotations;

namespace Part5.Entities;

public class Class
{
    [Required]
    public int Id { get; private set; }
    [Required]
    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<UserClass> UserClasses { get; private set; }
    private Class()
    {
    }

    public static Class Create(CreateClassRequest request)
    {
        return new()
        {
            Name = request.Name,
            Description = request.Description,
        };
    }
}
