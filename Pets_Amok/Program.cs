using System;

namespace Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Main_Menu();
        }

      
       
        static void Main_Menu()
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets, Inc. Here we have created a virtual interactive full spectrum pet experience.");
            Console.WriteLine("");
            Console.WriteLine("Please select from the options below.");

            bool running = true;
            PetClass temp_pet = new PetClass();
            while (running)
            {
                string userInput = Console.ReadLine();
                     
                        
                
                {

                    switch (userInput) { 
                    case "1":
                        Console.WriteLine("Create your pet");
                        break;
                    case "2":
                            Console.WriteLine("Here are the instructions, under constructions");
                            // working on instructions
                        break;
                    case "3":
                        Console.WriteLine("Play with you pet");
                        break;
                    case "4":
                        Console.WriteLine("Take your pet to the doctors:");
                    break;
                    case "5":
                        Console.WriteLine("Feed you pet");
                    break;
                    case "6":
                        Console.WriteLine("Check your pets status");
                        break;
                    case "7":
                        Console.WriteLine("Check your pets info");
                        break;
                    case "8":
                        Console.WriteLine("Here are our instructions");
                        Console.WriteLine("press 3 to  play with cat");
                        Console.WriteLine("press 4 to  take to doctor");
                        Console.WriteLine("press 5 to  feed to cat");
                        Console.WriteLine("press 6 to check your pets status");
                        Console.WriteLine("press 7 to check your pet's info");
                        Console.WriteLine("press 0 to quit");
                        break;
                        case "0":
                        running = false;
                        break;
                                                
                    default:
                        Console.WriteLine("You entered an invalid response please select from menu again");
                        break;



                    } }
                        

               
                }


            }



        }

    }


