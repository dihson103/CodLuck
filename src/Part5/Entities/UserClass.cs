using System.ComponentModel.DataAnnotations;

namespace Part5.Entities;

public class UserClass
{
    public int UserId { get; private set; }
    public int ClassId { get; private set; }
    public User User { get; private set; }
    public Class Class { get; private set; }
    public DateTime EnrollDate { get; private set; }
    private UserClass()
    {
    }
    public static UserClass Create(int userId, int classId)
    {
        return new UserClass()
        {
            UserId = userId,
            ClassId = classId,
            EnrollDate = DateTime.Now,
        };
    }
}
