using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class PetClass
    {
        Random rand = new Random();
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
        
        int health=50;  //min 0 max 100
        int hunger=50 ; //min 0 max 100
        int entertain=50 ; //min 0 max 100

        public int Health
        {
            get {
                
                return health;
            }
            set {
             
                    health = value;
            }
        }
          
        
        public int Entertain
        {
            get { return entertain; }
           set {  entertain = value; }
        } 
        public int Hunger {
            get { return hunger; }
            set
            {
                if (value < 0 && value > 90) { }
                else
                {
                    hunger = value;
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
        public  void Tick()
        { 
            Entertain = Entertain - 5;
            Health = Health - 5;
            Hunger = Hunger - 5;

        }
}
}

