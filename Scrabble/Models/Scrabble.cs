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
                char[] onePointArr = new char[] { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' };

                char[] twoPointArr = new char[] { 'd', 'g'};

                char[] userArray = userInput.ToLower().ToCharArray();
                
                for(int i = 0; i < userArray.Length; i++)
                {
                if (onePointArr.Contains(userArray[i]))
                {
                    totalPoints++;
                }
                else if (twoPointArr.Contains(userArray[i]))
                {
                 totalPoints += 2;   
                }
            
            }
            
             return totalPoints;

            }

    }
 
}
