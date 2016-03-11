using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Udemy_Ex4
{
    class Program
    {
        /// <summary>
        /// Write a program that picks a random number between 1 and 10. 
        /// Give the user 4 chances to guess the number. 
        /// If the user guesses the number, display “You won"; otherwise, display “You lost". 
        /// (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        /// </summary>
        
        static void Main(string[] args)
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            const int numberOfTries = 4;
            var playerNumTries = 1;

            Console.WriteLine("random number is: {0}",randomNumber);

            Console.WriteLine("You have 4 tries to guess the number.");
                        
            while (playerNumTries <= numberOfTries)
            {
                Console.WriteLine("Enter a number...");
                var input = Convert.ToInt32( Console.ReadLine() );
                playerNumTries++;

                if (input == randomNumber)
                {
                    Console.WriteLine("You won");
                    break;
                }
                else
                {
                    Console.WriteLine("You Lost");
                }
            }



        }
    }
}
