using System;

public class Player
{
  public int health = 100;

 private string _name = "Mario";
   

 private int id = 100;

 public Player( string newName = "Mario" )
 {

     // dit is de constructor funtie
     _name = newName;
 }
  
  public void Jump()
  {
    Console.WriteLine(name + "Spring :D");

  }

  public void Shoot(int amount)
  {
    Console.WriteLine(name + "Schiet " + amount + ":D");
  }

}