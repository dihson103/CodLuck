namespace Part_2.Models;

public class Student : Person
{
    public Student()
    {
        name = "Student";
    }
    public override void Work()
    {
        Console.WriteLine($"{name} is working ....");
    }

    public override void Eat()
    {
        Console.WriteLine($"{name} is eating ...");
    }
}
