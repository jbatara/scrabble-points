// TESTS GO IN HERE
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;
// ^^ THIS LINE IS TO GIVE US ACCESS TO SCRABBLE.CS FILE (THE BACKEND)
using System;


namespace Scrabble.Testing
{
    [TestClass]
    public class LetterTest
    {
        [TestMethod]
        public void CheckIfLetter_ChecksIfInputIsLetter_True()
    

        {
            string userInput = "a";
            bool expected = true;
            bool actual = Game.CheckIfLetter(userInput);
            // ^^ need "Game." because its the name of the class that holds this method, and its a static method. 

            Assert.AreEqual(expected, actual);
        }
    
    }









}
