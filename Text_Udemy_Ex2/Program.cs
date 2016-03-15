using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Udemy_Ex2
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. 
        /// If the user simply presses Enter, without supplying an input, exit immediately; 
        /// otherwise, check to see if there are duplicates. 
        /// If so, display "Duplicate" on the console.
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated with hyphens...");
            var input = Console.ReadLine();
            var arr = input.Split('-');
            var isDuplicate = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (isDuplicate == false)
                {
                    Console.WriteLine("outer {0}", arr[i]);
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        Console.WriteLine("inner {0}", arr[j]);
                        if (arr[i] == arr[j])
                        {
                            Console.WriteLine("Duplicate");
                            isDuplicate = true;
                            break;
                        }
                    }
                }
            }
        }
    }
}
