using System;

namespace classes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Charatcer myBaseClass = new Charatcer();
            myBaseClass.Walk();

            Mario myMario = new Mario();
            myMario.Walk();
            myMario.Shoot();
            myMario.Shoot(5);
        }
    }
}
