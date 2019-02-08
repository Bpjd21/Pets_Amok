using System;
using Xunit;
using Pets_Amok;
using System.Collections.Generic;
namespace Pets_Amok.test
{
    public class ShelterTest
    {


        [Fact]
        public void Should_add_Roboticpet_in_List()
        { 
            //ARRANGE
            var test_shelter = new Shelter(); // Once instance is created it automatically adds nine pets in the list.

            test_shelter.Pet.Clear();// Just for test purposes we need to clear List using built-in Method Clear()
            var organic = new RoboticPetClass("Tom", 12, "Cat");
           test_shelter.Pet.Add(organic);
            //ARRANGE
            Assert.Equal("Tom", test_shelter.Pet[0].Name);         
        }
 
         
  
       
        [Fact]
        public void Should_Select_Pet() //Selects pet By ID
        {
            //ARRANGE
            var test_shelter = new Shelter(); // Once instance is created it automatically adds nine pets in the list.
            //ACT
            test_shelter.Pet.Clear();// Just for test purposes we need to clear List using built-in Method Clear()
            
            OrganicPetClass temp_organic=new OrganicPetClass("Tom",15,"Lion"); //add  in PET LIST as organic pet
            test_shelter.Pet.Add(temp_organic);
            //ASSERT
            Assert.Equal(temp_organic, test_shelter.Select_Pet(0));
  
            
        }
        [Fact]
        public void Should_Remove_Pet() //Adopt() Method in shelter class
        {
            //ARRANGE
            var test_shelter = new Shelter();
            //ACT
            test_shelter.Pet.Clear(); //Remove all items from LIST
          
            OrganicPetClass temp_organic = new OrganicPetClass("Tom", 15, "Lion"); //add  in PET LIST as organic pet
            test_shelter.Pet.Add(temp_organic); // Addes in Pet List
            test_shelter.Adopt(0); // Removes from  Pet List
            //ASSERT
            Assert.Empty(test_shelter.Pet);
        }
    }
}


