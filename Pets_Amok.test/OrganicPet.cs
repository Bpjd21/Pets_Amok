using System;
using Xunit;
using Pets_Amok;
using System.Collections.Generic;
namespace Pets_Amok.test
{
    public class PetClasstest
    {
        [Fact]
        public void Create_instance_test()//get rid of this
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
            dog.Play();
            // ASSERT
            Assert.Equal(5, dog.Entertain);
        }
        [Fact]
        public void Test_health()
        {
            //ARRANGE
            PetClass dog = new PetClass();
            //ACT
            dog.PetMaintenance();
            //ASSERT
            Assert.Equal(5, dog.Health);
        }
        [Fact]
        public void Test_Hunger_Levels_Increase()
        {
            //ARRANGE
            PetClass pet = new PetClass();
            
            //ACT
            pet.Feed();
            //ASSERT
            Assert.Equal(5, pet.Hunger);
        }
        [Fact]
        public void Test_hunger_level_AFTER_VISIT_TO_DR() //Visit to doctor should decreases hunger by 10
        {
            //ARRANGE
            PetClass mypet = new PetClass();
            //ACT
            mypet.PetMaintenance();
            mypet.Feed();
            //ASSERT
            Assert.Equal(10, mypet.Feed());
        }
        [Fact]
        public void Test_constructor() //After create constructor testing if Name holds  value
        {
            //ARRANGE
            PetClass pet = new PetClass("Bob",12,"Lion");
            //ACT
            string  testname = pet.Name;
            //ASSERT
            Assert.Equal("Bob", testname);
        }
    }
}


