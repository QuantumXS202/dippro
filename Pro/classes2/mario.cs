using System;

public class Mario : Charatcer
{

    public bool isRunning = false;
    public string item = "";

    public Mario()
    {
        Console.WriteLine("Mario Constructor");

        id = "Mario";
        Console.WriteLine("ID is nu " + id);
    }
    public void Shoot()
    {
        Console.WriteLine("Shoot");
    }

    public void Shoot(int amount)
    {
        Console.WriteLine("mario shoots " + amount + " times");
    }

    public void Jump()
    {
        Console.WriteLine("Jump");
    }

    public override void Walk()
    {
        base.Walk();

        Console.WriteLine("Mario is aan het lopen");
    }
}