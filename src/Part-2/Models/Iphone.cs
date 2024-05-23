namespace Part_2.Models;

public class Iphone : Product
{
    public Iphone()
    {
        price = 100;
    }
    public override void ShowInfo()
    {
        Console.WriteLine("This is Iphone");
    }
}
