using System;
using Xunit;
using Pets_Amok;
namespace RoboticPetClassTests
{
    public class RoboticPetTest
    {
     //create instance is in progress
        
        [Fact]
        public void CanChargeRoboticPet()
        {
            //Arrange
            var TestRoboticPet = new RoboticPetClass("Dave", 6, "Dog");

            //Act
            TestRoboticPet.Feed();

            //Assert
            Assert.Equal(90, TestRoboticPet.Hunger);
        }

        [Fact]
        public void CanServiceRoboticPet()
        {
            //Arrange
            var TestRoboticPet = new RoboticPetClass("Dave", 6, "Dog");

            //Act
            TestRoboticPet.PetMaintenance();

            //Assert
            Assert.Equal(95, TestRoboticPet.Health);
        }

        [Fact]
        public void CanPlayWithRoboticPet()
        {
            //Arrange
            var TestRoboticPet = new RoboticPetClass("Dave", 6, "Dog");

            //Act
            TestRoboticPet.Play();

            //Assert
            Assert.Equal(90, TestRoboticPet.Entertain);

        }
    }
}
