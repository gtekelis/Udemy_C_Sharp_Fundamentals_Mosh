using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Udemy_Ex4
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        /// The list of numbers may include duplicates. 
        /// Display the unique numbers that the user has entered.
        /// </summary>

        static void Main(string[] args)
        {
            var numbersList = new List<int>();
            var distinctNumbers = new List<int>();
            var input = "";
            while (true)
            {
                Console.WriteLine("Enter a number or type quit to exit...");
                input = Console.ReadLine();
                
                if (input != "quit")
                {
                    numbersList.Add(Convert.ToInt32(input));
                    continue;
                }
                break;                
            }

            distinctNumbers = numbersList.Distinct().ToList();

            foreach (var item in distinctNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
