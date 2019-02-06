using System;
using System.Collections.Generic;
using System.Text;

namespace Pets_Amok
{
    public class RoboticPetClass : PetClass
    {
        public RoboticPetClass(string name, int age, string species) : base(name, age, species){

            Health = 90;
            Hunger = 90;
            Entertain = 90;
        }

       
    }
}
