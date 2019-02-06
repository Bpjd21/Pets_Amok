using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class RoboticPetClass : PetClass
    {
        public RoboticPetClass(string name, int age, string species) : base(name, age, species)
        {

            Health = 90;
            Hunger = 90;
            Entertain = 90;
        }
        public void Info()
        {
            Console.WriteLine("This is " + Name + "  . I am a Robotic " + Species + ".  I am  " + Age + " years old!! ");
        }

        public void Status()//leave for now
        {
            Console.WriteLine("\t\t\t Battery Level :  {0}", Hunger);
            Console.WriteLine("\t\t\t Oil Level :  {0}", Health);
            Console.WriteLine("\t\t\t Entertainment : {0}", Entertain);
        }

    }
}
