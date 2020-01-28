using System;

public class Charatcer
{
    public string id = "charatcerBase";

    public int points = 0;

    public float speed = 10.0f;

    public int lives = 3;

    public Charatcer()
    {
        Console.WriteLine("Consturctor");
    }


    public virtual void Walk()
    {
        Console.WriteLine("Walk");
    }

    
    public void Die()
    {
        Console.WriteLine("Die");
    }
}
