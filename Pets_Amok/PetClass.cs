using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class PetClass
    {
        //Pet attritbutes
        public int Age { get ;  set ;}
        public string Name { get ;  set ;}
        public string Species{ get ;  set ;}
        //Constructors
        public PetClass(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }
        public PetClass()
        {

        }

        //Pet's status
        int health = 50;
        int hunger = 50;
        int entertain = 50;
        public int Health
        { 
		get { return health; }
        set { health = value; } }
        public int Entertain
        {
            get { return entertain; }
            set { entertain = value; }
        } 
        public int Hunger {
            get { return hunger; }
            set { hunger = value; }
        }
        // entertainment with pet
        public int Play()
        {


            entertain = entertain + 10;
            hunger = hunger - 10;
            return entertain;


        }
        public int Visit_To_Doctor()
        {
            Health = Health + 10;
            Hunger = Hunger - 10;
            Entertain = Entertain - 10;
            return Health;}
        public int Feed()
        {Hunger = Hunger + 10;
            return Hunger;}
         //Pet details
        public void Info()
        {
            Console.WriteLine("My name is " + Name + "  . I am a " + Species + ".  I am  " + Age + " years old!! ");
        }
        public void Status() { 
               Console.WriteLine("\t\t\t Hunger :  {0}",Hunger);
                        Console.WriteLine("\t\t\t Health :  {0}", Health);
                        Console.WriteLine("\t\t\t Entertainment : {0}",Entertain);
        }
}
}

