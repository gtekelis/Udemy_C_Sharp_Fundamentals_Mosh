using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Udemy_Ex5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a series of numbers separated by comma. 
        /// Find the maximum of the numbers and display it on the console. 
        /// For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers seperated by commas");

            var input = Console.ReadLine();
            var arr = input.Split(',');

            //asume first number is the max
            int maxNumber = Convert.ToInt32(arr[0]);

            for (var i = 0; i < arr.Length; i++)
            {
                if ((Convert.ToInt32(arr[i]) > maxNumber))
                {
                    maxNumber = Convert.ToInt32(arr[i]);
                }
            }

            Console.WriteLine(maxNumber);
        }
    }
}
