using System;

using HulpClasses;
using HulpClasses.MeerClasses;

namespace scope_oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            player myPlayer = new player();

            myPlayer.getalA += 1;

            Basblass.statictekst += "Grapje";
            player.statictekst += "nog een grapje";


            HulpClassA test = new HulpClassA();

            HulpClassB test2 = new HulpClassB();

            HulpClassX test3 = new HulpClassX();

        }
    }
}
