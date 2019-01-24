using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class PetClass
    {

        int health = 50;
        int hunger = 50;
        int entertain = 50;

        public int Age { get ;  set ;}
        public string Name { get ;  set ;}
        public string Species{ get ;  set ;}

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
        public void Info()
        {

            Console.WriteLine("My name is " + Name + "  . I am a " + Species + ".  I am  " + Age + " years old!! ");
        }

        public int Play()
        {


            entertain = entertain + 10;
            hunger = hunger - 10;
            return entertain;


        }
        public int Visit_To_Doctor()
        {

            health = health + 10;
            hunger = hunger - 10;
            entertain = entertain - 10;
            return health;



        }
        public int Feed()
        {


            hunger = hunger + 10;


            return hunger;



        }
        public void Status()
        { Console.WriteLine("Your current pet's status is: " +
            " \n Entertainment level is {0} \n Hunger level is {1}  \n Health level is {2}", Entertain, Hunger, Health); }
    }
}

