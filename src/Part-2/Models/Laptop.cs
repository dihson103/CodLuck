namespace Part_2.Models;

public class Laptop : Product
{
    public Laptop()
    {
        price = 200;
    }
    public override void ShowInfo()
    {
        Console.WriteLine("This is Laptop");
    }

    public void ShowInfo(string owner)
    {
        Console.WriteLine($"This is {owner}'s laptop");
    }
}
