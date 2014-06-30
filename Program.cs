using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_ThaT_number_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play Guess That Number");

            GuessThatNumber();

            Console.WriteLine("TLets PLay");
            string answer = Console.ReadLine();
            string lower = answer.ToLower();
            if (lower == "yes")
            {
                GuessThatNumber();
            }
            else
            {
                Console.WriteLine("Nope");
            }
                      
            Console.ReadKey();
        }

        static void GuessThatNumber()
        {
            Console.WriteLine("What is the number");

            //computer picks a random number
            Random Guessess = new Random();
            int arbitrary = Guessess.Next(1, 101);
            
            int count = 0;
           
            int newInput = 0;

            Console.WriteLine("What number do you Pick");

            while (newInput != arbitrary)
            {                
                string yourGuess = Console.ReadLine();
                //changes string to int
                int input = int.Parse(yourGuess);

                if (input < arbitrary)
                {
                    //prints to the console
                    Console.WriteLine("Guess higher");
                    //adds 1 to the count
                    count++;
                }

                else if (input > arbitrary)
                {
                    Console.WriteLine("Guess Lower");
                    count++;
                }

                else if (input == arbitrary)
                {                 
                    Console.WriteLine("You guessed IT: It took you " + count + " guesses.");
                }
                
            }
        }
    }
}