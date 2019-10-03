// FRONT END CODE
using System;
using Scrabble;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a word to check the Scrabble-Score!");
        // ^^Prompts the user

        string userInput = Console.ReadLine();
        // ^^grabs value of userInput

        Game.CheckIfLetter(userInput);
        // checks if it meets the requirements spelled out in our CheckIfLetter method

        Game.CharValue(userInput);
        // ^^calls CharValue method to calc the value of each character in userInput and returns the total point val

        Console.WriteLine("The Scrabble-Score of your word is: " + Game.CharValue(userInput) + "!");
     
        
    }
}