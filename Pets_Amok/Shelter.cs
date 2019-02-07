using System;
using System.Collections.Generic;
using System.Text;


namespace Pets_Amok
{
    class Shelter
    {

        public List<PetClass> Pet { get; set; }
        public Shelter()
        {
            Pet = new List<PetClass>()
            {
                new OrganicPetClass("Bob", 12,"Cat"),
                new OrganicPetClass("Zach", 10, "Cat"),
                new RoboticPetClass("Mike", 8, "Cat"),
                new RoboticPetClass("Brian", 12, "Cat"),
                new OrganicPetClass("Fido", 9, "Cat"),
                new OrganicPetClass("Kitty", 6, "Dog"),
                new RoboticPetClass("Sammy", 12, "Dog"),
                new OrganicPetClass("Killian", 10, "Dog"),
                new OrganicPetClass("Honey", 2, "Dog"),
                new RoboticPetClass("Killer", 5, "Dog")
        };


        }
        public void Add(string name, int age, string specie)  // Create Pet 
        {
            Console.WriteLine("Type 'o' to create an organic pet or 'r'  to create a robotic pet");
            string type = Console.ReadLine();
            if (type.ToLower().Equals("o"))
            {
                Pet.Add(new OrganicPetClass(name, age, specie));
            }
            else if (type.ToLower().Equals("r"))
            {
                Pet.Add(new RoboticPetClass(name, age, specie));
            }
        }
        public void Adopt(int Id)
        {
            Pet.RemoveAt(Id);
        }
        public void Print_List()
        {
            string type = "";
            Console.WriteLine("\tID | NAME      |AGE|SPECIE|HUNGER|HEALTH|ENTERTAINMENT|   TYPE");
            for (int i = 0; i < Pet.Count; i++)
            {
                if (Pet[i].GetType() == typeof(RoboticPetClass))
                {
                    type = "Robotic";
                }
                else if (Pet[i].GetType() == typeof(OrganicPetClass))
                {
                    type = "Organic";
                }
                Console.WriteLine("\t{0}   {1}    {2}  {3} {4} {5}  {6}         {7}",
                   i.ToString().PadRight(2),
                   Pet[i].Name.PadRight(8).ToString(),
                   Pet[i].Age.ToString().PadRight(2),
                   Pet[i].Species.ToString().PadRight(8),
                   Pet[i].Hunger.ToString().PadRight(6),
                   Pet[i].Health.ToString().PadRight(6),
                   Pet[i].Entertain.ToString().PadRight(2),
                   type.ToString().PadRight(8));
            }
        }
        public void FeedAll()
        {
            for (int i = 0; i < Pet.Count; i++)
            {
                Pet[i].Feed();
            }
        }
        public void TakeallofthemtoDoctor()
        {
            for (int i = 0; i < Pet.Count; i++)
            {
                Pet[i].PetMaintenance();
            }
        }
        public void Cage() //Under Construction!
        { }
        public PetClass Select_Pet(int id)
        {
            return Pet[id];
        }
        public void TickAllOfThem()

        {
            for (int i = 0; i < Pet.Count; i++)
            {
                Pet[i].Tick();
            }
        }
        public void Checkstats()
        {
            for (int i = 0; i < Pet.Count; i++)
            {
                //   
            }
        }
        public static void Status(PetClass pet) //work at home linq
        {
            RoboticPetClass robotic;
            OrganicPetClass organic;


            if (pet.GetType() == typeof(RoboticPetClass))
            {
                robotic = pet as RoboticPetClass;
                robotic.Status();

            }
            else if (pet.GetType() == typeof(OrganicPetClass))
            {
                organic = pet as OrganicPetClass;
                organic.Status();
            }

        }

    }
}