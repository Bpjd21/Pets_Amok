using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class PetClass
    {      
        //Pet attritbutes
        public int Age { get ;  set ;} //Pet's Age
        public string Name { get ;  set ; }//Pet's Name
        public string Species{ get ;  set ; }//Pet's Specie
        private int Cage { get; set; } // 
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
        int health=50;  //min 0 max 100
        int hunger=50 ; //min 0 max 100
        int entertain=50 ; //min 0 max 100

        public int Health
        {
            get {
                
                return health;
                }
            set {
                if (value > -1 &&value<101 )
                {
                    health = value;
                }
                else
                {
                    

                }
            }
        }
          
        
        public int Entertain
        {
           get { return entertain; }
           set {
                if (value > -1 && value < 101) { entertain = value; }
            }
        } 
        public int Hunger {
            get { return hunger; }
            set
            {
                if (value > -1 && value < 101) { hunger = value; }
            }
        }
        // entertainment with pet
        public int Play()
        {
            Entertain = Entertain + 5;
            Hunger = Hunger - 5;
          return Entertain;
        }
        public int Visit_To_Doctor()
        {
            Health = Health + 5;
            Hunger = Hunger - 5;
            Entertain = Entertain - 5;
            return Health;
        }

        public int Feed()
        {
            Hunger = Hunger + 5;
            Entertain = Entertain + 5;
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
        public void Rename(string new_name)
        {
            Name = new_name;
        }
        public  void Tick()
        { 
            Entertain = Entertain - 5;
            Health = Health - 5;
            Hunger = Hunger - 5;
        }
}
}

