using System;

namespace oefenenclass
{
    class Program
    {
        static void Main(string[] args)
        {
          
         Player myPlayer = new Player();
         Player anotherPlayer = new Player("Pietje");
         Player ThirthPlayer = new Player("Henk");

          myPlayer.Jump();
          anotherPlayer.Shoot(4); 
          
          ThirthPlayer.Jump();
          ThirthPlayer.Shoot();
         
        }
    }
}
