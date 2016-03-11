using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Udemy_Ex5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        /// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
        /// otherwise, display the 3 smallest numbers in the list.
        /// </summary>

        static void Main(string[] args)
        {
            var numbersList = new List<int>();
            var tempList = new List<string>();
            var input = "";

            Console.WriteLine("Enter more than four numbers, comma separated.");
            input = Console.ReadLine();

            tempList = input.Split(',').ToList();

            if (tempList.Count == 0 || tempList.Count < 5)
            {
                Console.WriteLine("Invalid List");
            }
            else
            {
                foreach (var item in tempList)
                {
                    numbersList.Add(Convert.ToInt32(item));                    
                }

                numbersList.Sort();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbersList[i]);
                }
            }
        }
    }
}
