using System;

namespace Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome_Page();
            

        }
        static void Welcome_Page()
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets, Inc. Here we have created a virtual interactive full spectrum pet experience.");

            Console.WriteLine("Press to 1 play the game, 2 for the instructions to play the game, 0 to exit the game");
             // when user press 0 game ends
             // when user press 1 game starts
             // when user press 2 show instructions
            string userInput = Console.ReadLine();

            if (userInput.Equals("0"))
            {
                Console.WriteLine("Good Bye!");
            }
            // Insert instructions later
           if (userInput.Equals("1"))
            {
                PetClass temp_pat = new PetClass();
                Console.WriteLine("Hey Congrats!!! You adopted a cat");
                Console.WriteLine("What do you want to name your cat? ");
                temp_pat.Name = Console.ReadLine();
                Console.WriteLine("What is your cat's age ? ");
                temp_pat.Age = Convert.ToInt32(Console.ReadLine());


                temp_pat.info();
            }
           
           
        }
        
        }
       
    }

