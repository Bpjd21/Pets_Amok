using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class PetClass
    {
        //Pet attritbutes
        public int Age { get; set; } //Pet's Age
        public string Name { get; set; }//Pet's Name
        public string Species { get; set; }//Pet's Specie

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
        int health;  //min 0 max 100
        int hunger; //min 0 max 100
        int entertain; //min 0 max 100

        public int Health
        {
            get
            {

                return health;
            }
            set
            {
                if (value > -1 && value < 101)
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
            set
            {
                if (value > -1 && value < 101) { entertain = value; }
            }
        }
        public int Hunger
        {
            get { return hunger; }
            set
            {
                if (value > -1 && value < 101) { hunger = value; }
            }
        }
        // entertainment with pet
        public virtual void Play() //play
        {


        }
        public virtual void PetMaintenance() //take to dr or maintnance
        {

        }

        public virtual void Feed()
        {

        }
        //Pet details




        public void Rename(string new_name)
        {
            Name = new_name;
        }
        public virtual void Tick()
        {

        }

    }
}

