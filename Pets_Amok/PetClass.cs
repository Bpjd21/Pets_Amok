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
        int health = 50; //min 0 max 100
        int hunger = 50; //min 0 max 100
        int entertain = 50; //min 0 max 100
        public int Health
        {
            get { return health; }
            set
            {
                if (health > 0 && health < 100)
                { health = value; }
                else if (health == 100)
                {
                    Console.WriteLine("Your pet is in great Shape!!! Does not need to visit veterinarian");
                }
                else if (health < 30)
                {
                    Console.WriteLine("Your pet is not feeling good!!! please take him to the veterinarian!!!");
                }
            }
        }
        public int Entertain
        {
            get { return entertain; }
            set {
                if (entertain > 0 && entertain < 100)
                { entertain = value; }
                else if (entertain == 100)
                {
                    Console.WriteLine("Your pet is in super HAPPYYY!!!You don't need to play with it any more");
                }
                else if (entertain < 30)
                {
                    Console.WriteLine("Your pet is bored!!! You should play with it!!!");
                }

            }
        } 
        public int Hunger {
            get { return hunger; }
            set
            {
                if (hunger > 0 && hunger < 100)
                { hunger = value; }
                else if (hunger == 100)
                {
                    Console.WriteLine("Your pet is completely full !!! please stop feeding it.");
                }
                else if (hunger < 30)
                {
                    Console.WriteLine("Your pet is starving !!! Please feed it !!!");
                }
            }
        }
        // entertainment with pet
        public int Play()
        {


            Entertain = Entertain + 10;
            Hunger = Hunger - 10;
            return entertain;


        }
        public int Visit_To_Doctor()
        {
            Health = Health + 10;
            Hunger = Hunger - 10;
            Entertain = Entertain - 10;
            return Health;}
        public int Feed()
        {
            Hunger = Hunger + 10;
            return Hunger;
        }
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

