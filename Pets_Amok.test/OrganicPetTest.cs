using System;
using Xunit;
using Pets_Amok;
using System.Collections.Generic;
namespace Pets_Amok.test
{
    public class PetClasstest
    {


        [Fact]
        public void Test_Name()
        {
            PetClass dog = new PetClass();
            dog.Name = "Bob";
            Assert.Equal("Bob", dog.Name);
        }
 
         
  
       
        [Fact]
        public void Test_constructor() //After create constructor testing if Name holds  value
        {
            //ARRANGE
            PetClass pet = new PetClass("Bob", 12, "Lion");
            //ACT
            string testname = pet.Name;
            //ASSERT
            Assert.Equal("Bob", testname);
        }
    }
}


