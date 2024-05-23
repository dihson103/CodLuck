namespace Part_2.Models;

public class Cat : Animal
{
    public string Food {  get; set; }

    public Cat()
    {
        Legs = 4;
        Food = "Mouse";
    }

    public void ShowFood()
    {
        Console.WriteLine($"Cat's food is {Food}");
    }

    public override void Eat()
    {
        Console.WriteLine("Cat is eating");
    }
}
