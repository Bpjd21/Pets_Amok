using System;
using Xunit;
using Pets_Amok;
namespace XUnitTestProject1
{
    public class OrganicPetTest
    {

        [Fact]
        public void CanFeedOrganicPet()
        {
            //Arrange
            var TestOrganicPet = new OrganicPetClass("Dave", 6, "Dog");

            //Act
            TestOrganicPet.Feed();

            //Assert
            Assert.Equal(55, TestOrganicPet.Hunger);
        }

        [Fact]
        public void CanTakePetToVet()
        {
            //Arrange
            var TestOrganicPet = new OrganicPetClass("Dave", 6, "Dog");

            //Act
            TestOrganicPet.PetMaintenance();

            //Assert
            Assert.Equal(55, TestOrganicPet.Health);
        }

        [Fact]
        public void CanPlayWithOrganicPet()
        {
            //Arrange
            var TestOrganicPet = new OrganicPetClass("Dave", 6, "Dog");

            //Act
            TestOrganicPet.Play();

            //Assert
            Assert.Equal(55, TestOrganicPet.Entertain);

        }
    }
}
