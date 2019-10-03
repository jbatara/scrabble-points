// TESTS GO IN HERE
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;
// ^^ THIS LINE IS TO GIVE US ACCESS TO SCRABBLE.CS FILE (THE BACKEND)
using System;


namespace Scrabble.Testing
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void CheckIfLetter_ChecksIfInputIsLetter_True()
        {
            string userInput = "as";
            // ^^the string "as" is the example input here because the regex weve linked this test to requires two chars to work
            bool expected = true;
            bool actual = Game.CheckIfLetter(userInput);
            // ^^ need "Game." because its the name of the class that holds this method, and its a static method. 

            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
        public void CharValue_ChecksForLetterVal_Int()
       
        {
            string userInput = "super";
            int expected =  4;
            int actual = Game.CharValue(userInput);


            Assert.AreEqual(expected, actual);
        }
    
    }









}
