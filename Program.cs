using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            //This program is going to be awesome
            
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, baby. I make the functions and I make the calls.");
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Console.ReadKey();
        }
        //creating the function for the Disemvoweler
        static void Disemvoweler(string input)
        {
            //declaring funtion variables
            int i = 0;
            string consonantResult = "";
            string vowelResult = "";
            //setting up a loop to run through our input
            //and take out all the vowels
            for (i = 0; i < input.Length; i++)
            {
            //setting our index
                char letter = input[i];
                //pulling out the consonants and 
                //printing them to the console in order
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u' && letter != 'I' && letter != ' ' && letter != '!' && letter != '\'' && letter != '?' && letter != ',' && letter != '.')
                {
                    consonantResult += letter;
                }
                //pulling out the vowels and  
                //printing them to the console in order
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    vowelResult += letter;
                }
            //writing to the console to show our
            //our original input and then the 
            //input disemvoweled
                Console.WriteLine("Original: " + input);
                Console.WriteLine("Disemvoweled: " + consonantResult);
                Console.WriteLine("Vowels: " + vowelResult);
            }
        }
    }
}

