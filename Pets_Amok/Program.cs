using System;
using System.Collections.Generic;

namespace Pets_Amok
{
    class Program
    {
        static void Main(string[] args)
        {           
         

            List<PetClass> shelter = new List<PetClass>();
            shelter.Add(new PetClass("Bob", 12, "Cat" ));
            shelter.Add(new PetClass("Zach", 10, "Cat"));
            shelter.Add(new PetClass("Mike", 8, "Cat"));
            shelter.Add(new PetClass("Brian", 12, "Cat"));
            shelter.Add(new PetClass("Fido", 12, "Cat"));
            shelter.Add(new PetClass("Bob", 12, "Cat"));
            shelter.Add(new PetClass("Sammy", 12, "Dog"));
            shelter.Add(new PetClass("Killian", 10, "Dog"));
            shelter.Add(new PetClass("Honey Brown", 2, "Dog"));
            shelter.Add(new PetClass("Killer", 5, "Dog"));

            Main_Menu(shelter);
            

        } 
        static void Main_Menu(List<PetClass> anyPet)
        {
            Console.WriteLine("Hello! Welcome to Virtual Pets, Inc. Here we have created a virtual interactive full spectrum pet experience.");
            Console.WriteLine("");
            Console.WriteLine("\nplease select from the options below.");
            Console.WriteLine("\n======== Main_Menu ========");
            Console.WriteLine("press 1 to create your a pet ");
            Console.WriteLine("press 2 to view available pets in shelter");
            Console.WriteLine("press 3 to interact with your pet");
            Console.WriteLine("press 0 to quit");
            // needs work
           

            //Console.WriteLine("press 4 to take your pet to the doctor");
            //Console.WriteLine("press 5 to feed your pet");
            //Console.WriteLine("press 6 to check your pet's status");
            //Console.WriteLine("press 7 to check your pet's info");
            //Console.WriteLine("press 9 to check your pet's info");
            //Console.WriteLine("press 0 to quit");

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
                        
                            Console.Clear();
                            Console.WriteLine("Congratulations! You have created " + temp_pet.Name + " the " + temp_pet.Species + " who is " + temp_pet.Age + " years old. \nEnjoy your new pet!\n");
                            anyPet.Add(temp_pet);

                            Console.WriteLine("\n \n \n \n======== Menu ========");
                            Console.WriteLine("press 2 to view available pets in shelter");
                            ////Console.WriteLine("press 3 to play with your pet");                            
                            ////Console.WriteLine("press 4 to take your pet to the doctor");
                            ////Console.WriteLine("press 5 to feed your pet");
                            ////Console.WriteLine("press 6 to check your pet's status");
                            ////Console.WriteLine("press 7 to check your pet's info");
                            Console.WriteLine("press 0 to quit");
                            break;
                    case "2":
                            Console.WriteLine("View list of available pets in shelter");
                            PrintList(anyPet);
                        break;
                    case "3":
                        Console.WriteLine("\t\t\t\t ===== Play =====");
                            temp_pet.Play();
                        break;
                    case "4":
                        Console.WriteLine("\t\t\t\t ==={0} visited  to doctor Vet===",temp_pet.Name);
                            temp_pet.Visit_To_Doctor();
                    break;
                    case "5":
                        
                        Console.WriteLine("\t\t\t\t === {0} went to eat======",temp_pet.Name);
                            temp_pet.Feed();

                    break;
                    case "6":
                        Console.WriteLine("\t\t\t\t  === {0}'s sdtatus is ======",temp_pet.Name);
                            temp_pet.Status();
                        break;
                    case "7":
                        Console.WriteLine("Check your pets info");
                            temp_pet.Info();
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
        static void PrintList(List<PetClass> print)
        {
            Console.WriteLine("\t\t|ID  |NAME    | AGE | SPECIES |HUNGER |HEALTH|   ENTERTAIN");

            for (int i = 0; i <print.Count; i++)
            {
                Console.WriteLine("\t\t{0}    {1}   {2}    {3}   {4}   {5}   {6}", i.ToString(), print[i].Name, print[i].Age, print[i].Species, print[i].Hunger, print[i].Health, print[i].Entertain);
            }
        }


        }

    }


