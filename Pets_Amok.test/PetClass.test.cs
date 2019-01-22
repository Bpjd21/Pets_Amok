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
            Assert.Equal("Bob", dog.Name);
        } 
    }
}
