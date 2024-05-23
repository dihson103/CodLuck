namespace Part_2.Models;

public abstract class Person
{
    public string name;
    public void Say()
    {
        Console.WriteLine("Person is saying....");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Person is eating ....");
    }

    public abstract void Work();
}
