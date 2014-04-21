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
            //create variables 
            var numChar = input.Length;
            var numCharSplit = input.Split(' ');
            var numWords = numCharSplit.Length;
            int numVowels = 0;
            int numConsonant = 0;
            int numSpecChar = 0;

            var biggestWord = "";
            var shortestWord = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            //start for loop to run through the string passed in to find exact numbers of information 
            for (int i = 0; i < numCharSplit.Length; i++)
            {

                if (numCharSplit[i].Length > biggestWord.Length)
                {
                    biggestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < numCharSplit.Length; i++)
            {
                if (numCharSplit[i].Length < shortestWord.Length)
                {
                    shortestWord = numCharSplit[i];
                }
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == "a" || input[i].ToString() == "e" || input[i].ToString() == "i" || input[i].ToString() == "o" || input[i].ToString() == "u")
                {
                    numVowels = numVowels + 1;
                }
                else if (input[i].ToString() == "." || input[i].ToString() == "," || input[i].ToString() == "?" || input[i].ToString() == "!" || input[i].ToString() == "'")
                {
                    numSpecChar = numSpecChar + 1;
                }

                else if (input[i].ToString() != " ")
                {
                    numConsonant = numConsonant + 1;
                }
            }
        }
        
    }
}
