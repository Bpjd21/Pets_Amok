using System;

namespace Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            Wellcome_Page();
         }
        static void Wellcome_Page()
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
                Start_Game();
            }
           
           
        }
        static void Start_Game()
        {
            
            Console.WriteLine("Press 1 for Organic)" 
                // or press 2 for Robotic Pet");
            string user_Choice = Console.ReadLine();
            if (user_Choice.Equals("1"))
            {
                Console.WriteLine("Organic Pet");
                Organic Daisy = new Organic("Daisy", "3");
                Organic Tom = new Organic("Tom", "1");
                Organic Thumper = new Organic("Thumper", "5");
                Daisy.Print_info();
                Tom.Print_info();
                Thumper.Print_info();
            }
            else if(user_Choice.Equals("2"))
{
                Console.WriteLine("Robotic");
}
        }
       
    }
}
