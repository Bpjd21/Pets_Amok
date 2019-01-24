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
            Console.WriteLine("\nplease select from the options below.");
            Console.WriteLine("press 1 to create your a pet ");
            Console.WriteLine("press 3 to play with your pet");
            Console.WriteLine("press 4 to take your pet to the doctor");
            Console.WriteLine("press 5 to feed your pet");
            Console.WriteLine("press 6 to check your pet's status");
            Console.WriteLine("press 7 to check your pet's info");
            Console.WriteLine("press 0 to quit");

            bool running = true;
            PetClass temp_pet = new PetClass();
            while (running)
            {
                string userInput = Console.ReadLine();
                     
                        
                
                {

                    switch (userInput) { 
                    case "1":
                        Console.WriteLine("\t\t\t\t Create your pet");
                        Console.Write("\nWhat would you like to name your pet?  ");
                        temp_pet.Name = Console.ReadLine();
                        Console.Write("How old is your pet?  ");
                        temp_pet.Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What species is your pet?  ");
                        temp_pet.Species = Console.ReadLine();
                            Console.WriteLine("Congratulations! You have created " + temp_pet.Name + " the " + temp_pet.Species + " who is " + temp_pet.Age + " years old. \nEnjoy your new pet!");
                        break;
                    case "2":
                            Console.WriteLine("Here are the instructions, under constructions ");
                            // working on instructions
                        break;
                    case "3":
                        Console.WriteLine("\t\t\t\t ===== Play =====");
                        break;
                    case "4":
                        Console.WriteLine("\t\t\t\t Take your pet to the doctors:");
                    break;
                    case "5":
                        Console.WriteLine("\t\t\t\t Feed you pet");
                    break;
                    case "6":
                        Console.WriteLine("\t\t\t\t Check your pets status");
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


