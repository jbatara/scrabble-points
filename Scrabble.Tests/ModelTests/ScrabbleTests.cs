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
            // here we are checking to see if the userInput (which is being passed into the CheckIfLetter method, which lives in the Game class) is A. a letter and B. has a min of two characters

            Assert.AreEqual(expected, actual);
        }

         [TestMethod]
        public void CharValue_ChecksForLetterVal_Int()
        {
            string userInput = "zebra";
            int expected =  16;
            int actual = Game.CharValue(userInput);
            // "actual" represents what will perform the function to pass the test. in this case its the userInput, being passed into the CharValue method, which lives in the Game class.

            Assert.AreEqual(expected, actual);
        }
    
    }









}
