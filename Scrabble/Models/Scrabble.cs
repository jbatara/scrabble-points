// BACKEND CODE GOES IN HERE
using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Scrabble
{
    public class Game
    {
        public static bool CheckIfLetter(string userInput)
        {
            Regex reg = new Regex(@"[a-zA-Z]{2,}");
            // IN THE REGEX THE CURLY BOYS WITH THE "2," INDICATES THAT THE STRING MNUST START WITH A LETTER AND ALSO HAVE 2 OR MORE OF THEM
            if(reg.IsMatch(userInput))
            {
                // ScrabbleScore();
                return true;
            }
            else 
            {
                Console.WriteLine("PLease enter a letter or a word.");
                return false;
            }
        
        }
            public static int CharValue(string userInput)
            {
                int totalPoints = 0;
                // ^^ we declare this here so that we can update its value throughout the method

                char[] userArray = userInput.ToLower().ToCharArray();
                // We know were going to loop through each word and each individual character in the word needs a value. So we parse userInput into an array so that in the next step we can assign each character a value.

                char[] onePointArr = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };
                // here we group characters together in an array. we put them together so that later when we loop through them they will all share a value.

                char[] twoPointArr = new char[] { 'd', 'g'};
                
                char[] threePointArr = new char[] { 'b', 'c', 'm', 'p' };
                 
                char[] fourPointArr = new char[] { 'f', 'h', 'v', 'w', 'y' };
                
                char[] fivePointArr = new char[] { 'k' };
                
                char[] eightPointArr = new char[] { 'j', 'x' };

                char[] tenPointArr = new char[] { 'q', 'z' };
                
                for(int i = 0; i < userArray.Length; i++)
                {
                if (onePointArr.Contains(userArray[i]))
                {
                    totalPoints++;
                // here we loop through userArray by individual character. we add to totalPoints here as well
                }
                else if (twoPointArr.Contains(userArray[i]))
                {
                 totalPoints += 2;   
                }
                else if (threePointArr.Contains(userArray[i]))
                {
                 totalPoints += 3;   
                }
                else if (fourPointArr.Contains(userArray[i]))
                {
                 totalPoints += 4;   
                }
                else if (fivePointArr.Contains(userArray[i]))
                {
                 totalPoints += 5;   
                }
                else if (eightPointArr.Contains(userArray[i]))
                {
                 totalPoints += 8;   
                }
                else if (tenPointArr.Contains(userArray[i]))
                {
                 totalPoints += 10;   
                }
            }
             return totalPoints;
            //  here is were we get the final point total
            }
    }
}
