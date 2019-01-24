using System;

namespace Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            PetClass temp_pet = new PetClass();
            bool running = true;
            Welcome_Page();
            while (running)
            {
                string userInput = Console.ReadLine();

                if (userInput.Equals("0"))
                {
                    running = false;
                    Console.WriteLine("Bye Bye see u later!!!");
                }
                // Insert instructions later
                else if (userInput.Equals("1"))
                {


                    Console.WriteLine("Hey Congrats!!! You adopted a cat");
                    Console.WriteLine("What do you want to name your cat? ");
                    temp_pet.Name = Console.ReadLine();
                    Console.WriteLine("What is your cat's age ? ");
                    temp_pet.Age = Convert.ToInt32(Console.ReadLine());

                }
                else if (userInput.Equals("2"))
                {
                    Console.WriteLine("press 0 to quit");
                    Console.WriteLine("press 3 to  play with cat");
                    Console.WriteLine("press 4 to  take to doctor");
                    Console.WriteLine("press 5 to  feed to cat");
                    Console.WriteLine("press 7 to check status");
                    Console.WriteLine("press 8 to check status");
                }
                else if (userInput.Equals("3"))
                {
                    temp_pet.Play();
                    Console.WriteLine("Pet went to play!!!");

                }
                else if (userInput.Equals("4"))
                {
                    temp_pet.Visit_To_Doctor();
                    Console.WriteLine("Pet went to Doctor!!!!");
                }
                else if (userInput.Equals("5"))
                {
                    temp_pet.Feed();
                    Console.WriteLine("Pet ate some food");
                }
                else if (userInput.Equals("7"))
                {
                    Console.WriteLine(" \n My Current health level is " + temp_pet.Health +
                                    "  \n My current hunger level is " + temp_pet.Hunger +
                                    "\n My current entertainment level is " + temp_pet.Entertain);
                }
                else if (userInput.Equals("8"))
                {
                    temp_pet.info();
                }
                else
                {
                    Console.WriteLine("press 0 to quit");
                    Console.WriteLine("press 3 to  play with cat");
                    Console.WriteLine("press 4 to  take to doctor");
                    Console.WriteLine("press 5 to  feed to cat");
                    Console.WriteLine("press 7 to check status");
                    Console.WriteLine("press 8 to check status");
                }
            }
        }
        static void Welcome_Page()
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets, Inc. Here we have created a virtual interactive full spectrum pet experience.");

            Console.WriteLine("Press to 1 play the game, 2 for the instructions to play the game, 0 to exit the game");
        }
    }
   
}


