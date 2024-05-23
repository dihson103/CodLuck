namespace Part_2.Models;

public abstract class Product
{
    protected double price = 0;
    public abstract void ShowInfo();
    public void TestShow()
    {
        this.ShowInfo();
    }
}
