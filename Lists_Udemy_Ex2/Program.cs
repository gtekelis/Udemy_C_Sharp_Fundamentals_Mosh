using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Udemy_Ex2
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter their name. 
        /// Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>

        static void Main(string[] args)
        {
            var name = "";
            var reversedName = "";

            Console.WriteLine("Enter your name....");

            name = Console.ReadLine();

            string[] reverseName = new string[name.Length];

            for (int i = 0; i < name.Length; i++)
            {
                reverseName[i] = Convert.ToString(name[i]);
            }

            Array.Reverse(reverseName);

            for (int i = 0; i < reverseName.Length; i++)
            {
                reversedName += reverseName[i];
            }

            Console.WriteLine(reversedName);

        }
    }
}
