namespace Part_2.Models;

public class Animal
{
    public int Legs { get; set; }
    public float Weights { get; set; }
    public void ShowLegs ()
    {
        Console.WriteLine($"Animal has {Legs} legs");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
