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
                new PetClass("Bob", 12,"Cat"),
                new PetClass("Zach", 10, "Cat"),
                new PetClass("Mike", 8, "Cat"),
                new PetClass("Brian", 12, "Cat"),
                new PetClass("Fido", 9, "Cat"),
                new PetClass("Kitty", 6, "Dog"),
                new PetClass("Sammy", 12, "Dog"),
                new PetClass("Killian", 10, "Dog"),
                new PetClass("Honey", 2, "Dog"),
                new PetClass("Killer", 5, "Dog")
            };

        }
        public void Add(PetClass pet)
        {
            Pet.Add(pet);
        }
        public void Adopt(int Id)
        {        
            Pet.RemoveAt(Id);
        }
        public void Print_List()
        {
            Console.WriteLine("\tID | NAME      |AGE|SPECIE|HUNGER|HEALTH|ENTERTAINMENT|");
            for (int i = 0; i < Pet.Count; i++)
            {  
                Console.WriteLine("\t{0}   {1}   {2}  {3} {4} {5}  {6}", 
                    i.ToString().PadRight(2),
                    Pet[i].Name.PadRight(8).ToString(),
                    Pet[i].Age.ToString().PadRight(2), 
                    Pet[i].Species.ToString().PadRight(8), 
                    Pet[i].Hunger.ToString().PadRight(6),
                    Pet[i].Health.ToString().PadRight(6), 
                    Pet[i].Entertain.ToString().PadRight(2));       
            }
        }
        public  void FeedAll()
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
                Pet[i].Visit_To_Doctor();
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
            for(int i = 0; i < Pet.Count; i++)
            {
                Pet[i].Tick();
            }
        }
        public void Checkstats()
        {
            for(int i = 0; i < Pet.Count; i++)
            {
              //   
            }
        }
    }
}
