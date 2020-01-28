using System;

namespace getters_en_setters
{
    class Program
    {
        static void Main(string[] args)
        {
           player myPlayer = new player();

            Console.WriteLine("LIVES:" + myPlayer.lives);
            Console.WriteLine("POINTS:" + myPlayer.points);
            Console.WriteLine("NAME:" + myPlayer.name);
            Console.WriteLine("WEAPON:" + myPlayer.weapon);
        }
    }
}
