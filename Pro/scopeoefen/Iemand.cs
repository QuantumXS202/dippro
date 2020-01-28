using System;

namespace Henkie
{
    public class Iemand
    {
        public int lives = 20;
        private string Name = "Dora";

        protected int Getal = 5;

        public void Walk()
        {
            Console.WriteLine(Name);
        }

        private void Fly()
        {
            Console.WriteLine(Getal);

        }

        protected void Shoot()
        {

        }
    }
}

