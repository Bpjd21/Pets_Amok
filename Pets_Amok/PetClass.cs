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
            Console.WriteLine("plaaayyy");
            if (Entertain >= 90 || Entertain>= 0)
            {
                Entertain = Entertain + 10;
 
            }
            
            return Entertain;
        }
        public int Visit_To_Doctor()
        {
            if (health <= 90 || health >= 0)
            {
                health = health + 10;
                
            }
            return health;
            Console.WriteLine("visited drrrrr");

        }
        public int Feed()
        {
            if (hunger <= 90 || hunger >= 0)
            {
                hunger = health + 10;

            }
            return hunger;
            Console.WriteLine("feeeeeeeeeed");

        }

    }
}
