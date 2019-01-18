using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    class Organic
    {
     public   string name;
    public    string species;
        string age;
        string color;
        string behavior;
        string breed;
        public Organic(string Name, string Species)
        {
            name = Name;
            species = Species;
        }
        public void Print_info()
        {
            Console.WriteLine("This is pet  {0} And he is {1} years Old", name, species);
        }
    }
}
