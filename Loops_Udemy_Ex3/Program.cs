using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Udemy_Ex3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a number. 
        /// Compute the factorial of the number and print it on the console. 
        /// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        /// </summary>        

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");

            var input = Convert.ToInt32( Console.ReadLine() );
            var result = 1;

            for (var i = input; i >= 1; i--)
            {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}", input, result);
        }
    }
}
