// BACKEND CODE GOES IN HERE
using System;
using System.Text.RegularExpressions;


namespace Scrabble
{
    public class Game
    {
        // public string Letter {get; set;}
        // public int LetterPoint {get; set;}

        public static bool CheckIfLetter(string userInput)
        {
            Regex reg = new Regex(@"[a-zA-Z]");
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
            
            
            // char[] userArray = userInput.ToCharArray();
            // Console.WriteLine(userArray);
        }

    }
 
}
