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
        
        int health = 50;
        int hunger = 50;
        int entertain = 50;
       
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
       
        public int Health
        { get { return health; }
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
        public void info()
        {
           
            Console.WriteLine("My name is " + name + "  . I am a " + species + ".  I am  " + age+" years old!! ");
        }
        
        public int Play()
        {
            
           
            entertain = entertain+ 10;
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
           
            if (hunger <= 90 && hunger >= 0)
            {
                hunger = hunger + 10;

            }
            return hunger;
            


        }

    }
}
