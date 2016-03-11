using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Udemy_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program and ask the user to enter a number. 
            The number should be between 1 to 10. 
            If the user enters a valid number, display "Valid" on the console. 
            Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            */
            
            Console.WriteLine("Please enter a number between 1 - 10");

            int givenNumber = Convert.ToInt32( Console.ReadLine() );

            if (givenNumber >= 1 && givenNumber <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
