using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Udemy_Ex1
{
    class Program
    {
        /// <summary>
        /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        /// Display the count on the console.
        /// </summary>
        
        static void Main(string[] args)
        {
            var counter = 0;

            for (var i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    counter += 1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
