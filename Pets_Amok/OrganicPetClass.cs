using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class OrganicPetClass : PetClass
    {
        public OrganicPetClass(string name, int age, string species) : base(name, age, species)
        {
            Health = 70;
            Hunger = 70;
            Entertain = 70;
        }
        public void Info()
        {
            Console.WriteLine("This is " + Name + ". I am an Organic " + Species + ". I am  " + Age + " years old!! ");
        }

        public void Status()
        {
            Console.WriteLine("\t\t\t Hunger :  {0}", Hunger);
            Console.WriteLine("\t\t\t Health :  {0}", Health);
            Console.WriteLine("\t\t\t Entertainment : {0}", Entertain);
        }
        public override void Play()
        {
            Entertain = Entertain + 10;
            Hunger = Hunger - 5;

        }
        public override void PetMaintenance()
        {
            Health = Health + 5;
            Hunger = Hunger - 5;
            Entertain = Entertain - 5;

        }

        public override void Feed()
        {
            Hunger = Hunger + 20;
            Entertain = Entertain + 5;

        }
        public override void Tick()
        {
            Entertain = Entertain - 5;
            Health = Health - 5;
            Hunger = Hunger - 5;
        }
    }
}
