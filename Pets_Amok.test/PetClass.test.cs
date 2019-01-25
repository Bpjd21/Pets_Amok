using System;
using Xunit;
using Pets_Amok;
using System.Collections.Generic;
namespace Pets_Amok.test
{
    public class PetClasstest
    {
        [Fact]
        public void Create_instance_test()
        {
            new PetClass();
        }
        [Fact]
        public void Test_Name()
        {
            PetClass dog = new PetClass();
            dog.Name = "Bob";
            Assert.Equal("Bob", dog.Name);
        }
        [Fact]
        public void Test_Entertain_LEVEL()
        {
            //ARRANGE
            PetClass dog = new PetClass();
            //ACT
            dog.Visit_To_Doctor();
            // ASSERT
            Assert.Equal(40, dog.Entertain);
        }
        [Fact]
        public void Test_helth()
        {
            //ARRANGE
            PetClass dog = new PetClass();
            //ACT
            int health_level = dog.Visit_To_Doctor();
            //ASSERT
            Assert.Equal(60, health_level);
        }
        [Fact]
        public void Test_Hunger()
        {
            //ARRANGE
            PetClass pet = new PetClass();
            pet.Feed();
            //ACT
            int expected = pet.Hunger;
            //ASSERT
            Assert.Equal(60, expected);
        }
        [Fact]
        public void Test_hunger_level_AFTER_VISIT_TO_DR() //Visit to doctor should decreases hunger by 10
        {
            //ARRANGE
            PetClass mypet = new PetClass();
            //ACT
            mypet.Visit_To_Doctor();
            int expected = mypet.Hunger;
            //ASSERT
            Assert.Equal(40, expected);
        }
        
    }
}
