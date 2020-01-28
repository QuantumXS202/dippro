using System;
using System.Collections.Generic;
using System.Text;

public class player
{
    private int _lives = 10;
    public int lives
    {
        get 
        {
            return _lives;
        }
    }
    
    private int _points = 0;
        public int points 
        {
            get 
            {
                return _points;
            }
            set
            {
                if (value >= 100)
                {
                    value %= 100;
                    _lives += 1;
                }
                else if (value <0)
                {
                    value = 0;
                }
                _points = value;
            }
        }

    private string _weapon = "bijl";
    public string weapon 
    {
        get
        {
            return _weapon;
        }
    }

    private string _name = "Gerrit";
    public string name 
    {
        get 
        {
            return _name;
        }
    }


    private void jump()
        {
            Console.WriteLine("Spring");
        }
}
