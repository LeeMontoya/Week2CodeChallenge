using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //set a for loop that runs from 0-20
          for (var i = 0; i <= 20; i++)
          {
              fizzbuzz(i);
          }
          
            //calling the functions to pass in these parameters
            LetterCounter("i", "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter("n", "Never gonna give you up. Never gonna let you down.");
            LetterCounter("s", "Sally sells seashells down by the seashore. She's from Sussex.");

            TextStats("Never gonna give you up. Never gonna let you down. Never gonna run around and desert you.");

           Console.ReadKey();
        
        }
            //declaring fizzbuzz function with parameter called "number"
        static void fizzbuzz(int number)
        {
            //operations with if/else statements start below
            if (number % 3 == 0 && number % 5 == 0)
            {
                //print
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                //print
                Console.WriteLine("Buzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }

                      
        }   

            //declaring a function called LetterCounter with two parameters called "char <named> letter" & "string <named> inString"
        static void LetterCounter(string letter, string inString)
        {   //set int variables
            int lowCase = 0;
            int upCase = 0;
           

            //for loop that counts the number of upper and lower case letters
            for (int i = 0; i < inString.Length; i++)
            {
                var currentLetter = inString[i].ToString();
                if (letter.ToUpper() == currentLetter)
                {
                    //counting each uppercase letter in the string 
                    upCase += 1;
                }
                else if (letter.ToLower() == currentLetter)
                {
                    //counting each lowercase letter in the string
                    lowCase += 1;
                }

               
                    
            }
                //printing the number of upper and lower case letters to the console 
                Console.WriteLine("Input: " + inString);
                Console.WriteLine("Number of lowercase " + letter + "'s found: " + lowCase); 
                Console.WriteLine("Number of UPPERCASE " + letter + "'s found: " + upCase);
                Console.WriteLine("Total number of " + letter + "'s found: " + (lowCase + upCase));
        }
        //declare function called TextStats with parameter called input
        static void TextStats(string input)
        {
            //set variables to 0
            int numChars = input.Length - 1;
            int numWords = 0;
            int numVowels = 0;
            int numCons = 0;
            int numSpecial = 0;
            int longest = 0;
            int shortest = 0;


            //begin for loop to run through the string to count the given variables
            for (var i = 0; i <= input.Length - 1; i++)
            {

                var currentVowels = input[i];
                //counting how many vowels in the loop
                if (currentVowels == 'a' || currentVowels == 'e' || currentVowels == 'i' || currentVowels == 'o' || currentVowels == 'u')
                {
                    numVowels += 1;
                }
             
            }

            Console.WriteLine("Number of characters: " + numChars);
            Console.WriteLine("Number of words: " + numWords);
            Console.WriteLine("Number of vowels: " + numVowels);
            Console.WriteLine("Number of consonants: " + numCons);
            Console.WriteLine("Number of special characters: " + numSpecial);
            Console.WriteLine("Longest word: " + longest);
            Console.WriteLine("Shortest word: " + shortest);
        }
        
    }
}
