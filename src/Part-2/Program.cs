using Part_2.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Cat cat = new Cat();
        cat.ShowFood();
        cat.ShowLegs();
        cat.Eat();

        Animal animal = new Animal();
        animal.Eat();
        animal.ShowLegs();

        Laptop laptop = new Laptop();
        Iphone iphone = new Iphone();
        laptop.ShowInfo();
        iphone.TestShow();
        var owner = "Son";
        laptop.ShowInfo(owner);

        Student student = new Student();
        student.Say();
        student.Work();
        student.Eat();
    }
}