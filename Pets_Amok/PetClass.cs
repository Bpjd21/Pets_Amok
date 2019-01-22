using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
  public  class PetClass
    {
        
        int age;
        string name;
        string species="Cat";
        int hunger = 100;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Species
        {
            get { return species; }
            set { species = value; }
        }
        public int Hunger {
            get { return hunger; }
            set { hunger = value; }
        }
        public void info()
        {
           
            Console.WriteLine("My name is " + name + "  . I am a " + species + ".  I am  " + age+" years old!! ");
        }
        
        }
    }
}
