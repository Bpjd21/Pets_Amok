using System;
using Xunit;
using Pets_Amok;
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
            Assert.Equal("Bob", dog.Name );
        }

        [Fact]
        public  void Test_Entertain()
        {
            PetClass dog = new PetClass();
          
            Assert.Equal(60, dog.Play());
        }

        [Fact]
        public void Test_helth()
        {
            PetClass dog = new PetClass();
          
            Assert.Equal(60, dog.Visit_To_Doctor());
        }
    }
}
