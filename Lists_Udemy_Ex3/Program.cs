using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Udemy_Ex3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. 
        /// If a number has been previously entered, display an error message and ask the user to re-try. 
        /// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        /// </summary>

        static void Main(string[] args)
        {
            var numbersList = new List<int>();
            int givenNumber;

            Console.WriteLine("Give 5 numbers");

            while (numbersList.Count < 5)
            {
                Console.WriteLine("Number {0}", numbersList.Count + 1);
                givenNumber = Convert.ToInt32(Console.ReadLine());
                
                if (numbersList.Count < 1)
                {
                    numbersList.Add(givenNumber);
                }
                else if (numbersList.IndexOf(givenNumber) > -1)
                {
                    Console.WriteLine("Number exists, retry...");                    
                }
                else
                {
                    numbersList.Add(givenNumber);
                }
            }

            Console.WriteLine("sorting...");

            numbersList.Sort();

            foreach (var item in numbersList)
            {
                Console.WriteLine(item);
            }
        }
    }
}