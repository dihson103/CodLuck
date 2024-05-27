using Part_4;

internal class Program
{
    public static List<Student> Students = new List<Student>()
    {
        new Student()
        {
            Id =1,
            Name = "Nguyen Dinh Son",
            Address = "Ha Noi",
            Age = 23
        },
        new Student()
        {
            Id =2,
            Name = "Hoang Thi Huyen Trang",
            Address = "Ha Noi",
            Age = 18
        },
        new Student()
        {
            Id =3,
            Name = "Nguyen Thi Hue",
            Address = "Thanh Hoa",
            Age = 25
        },new Student()
        {
            Id =4,
            Name = "Nguyen Thanh Tam",
            Address = "Thanh Hoa",
            Age = 20
        },new Student()
        {
            Id =5,
            Name = "Nguyen Khanh Huyen",
            Address = "Ha Noi",
            Age = 22
        },
    };

    private static List<Student> GetStudentsAgeMoreThan20Query()
    {
        var students = (from student in Students
                       where student.Age > 20
                       select student)
                       .ToList();
        return students;
    }

    private static List<Student> GetStudentsAgeMoreThan20Method()
    {
        return Students.Where(s => s.Age > 20).ToList();  
    }

    private static List<Student> OrderyBy_Query()
    {
        var students = from s in Students
                      orderby s.Age
                      select s;
        return students.ToList();
    }

    private static List<Student> OrderyBy_Method()
    {
        return Students.OrderBy(s => s.Age).ToList();
    }

    private static List<Student> ThenBy()
    {
        return Students.OrderBy(s => s.Name).ThenBy(s => s.Age).ToList();
    }

    private static void GroupBy_Query()
    {
        var groups = from s in Students
                       group s by s.Address;

        foreach(var group in groups)
        {
            Console.WriteLine("Address: " + group.Key);
            foreach(var student in group)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Address} - {student.Age}");
            }
            Console.WriteLine();
        }
    }

    private static void GroupBy_Method()
    {
        var groups = Students.GroupBy(s => s.Address);

        foreach (var group in groups)
        {
            Console.WriteLine("Address: " + group.Key);
            foreach (var student in group)
            {
                Console.WriteLine($"{student.Id} - {student.Name} - {student.Address} - {student.Age}");
            }
            Console.WriteLine();
        }
    }

    private static void Any()
    {
        var isHaveLiveInHaNoi = Students.Any(s => s.Address.Equals("Ha Noi"));
        Console.WriteLine("are there any students live in ha noi?");
        Console.WriteLine(isHaveLiveInHaNoi ? "Yes" : "No");
    }

    private static void All()
    {
        var isAllLiveInHaNoi = Students.All(s => s.Address.Equals("Ha Noi"));
        Console.WriteLine("Do all students live in Hanoi?");
        Console.WriteLine(isAllLiveInHaNoi ? "Yes" : "No");
    }

    private static void Main(string[] args)
    {
        //var students = GetStudentsAgeMoreThan20Query();
        //var students = GetStudentsAgeMoreThan20Method();
        //foreach (var student in students)
        //{
        //    Console.WriteLine($"{student.Id} - {student.Name} - {student.Address} - {student.Age}");
        //}


        //GroupBy_Query();
        //GroupBy_Method();
        //Any();
        All();
    }
}