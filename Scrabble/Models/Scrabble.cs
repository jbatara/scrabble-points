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
            
            
            // char[] userArray = userInput.ToCharArray();
            // Console.WriteLine(userArray);
        }

    }
 
}
