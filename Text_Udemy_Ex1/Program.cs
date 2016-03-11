using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Udemy_Ex1
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. 
        /// Work out if the numbers are consecutive. 
        /// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Give numbers separated by hyphens");
            var numbers = Console.ReadLine();
            //Console.WriteLine(numbers);

            var arr1 = numbers.Split('-');
            var numsList = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                numsList.Add(Convert.ToInt32(arr1[i]));
            }
            

            foreach (var item in numsList)
            {
                Console.WriteLine(item);
            }

            var isConsecutive = true;
            for (int i = 1; i < numsList.Count; i++)
            {
                if (numsList[i] != numsList[i - 1] + 1) {
                    isConsecutive = false;
                }
                break;
            }
            Console.WriteLine( isConsecutive == true ? "Consecutive" : "Not Consecutive" );
        }
    }
}
