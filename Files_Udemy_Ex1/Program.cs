using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Udemy_Ex1
{
    class Program
    {
        /// <summary>
        /// Write a program that reads a text file and displays the number of words.
        /// </summary>

        static void Main(string[] args)
        {
            var path = @"c:\_Temp\udemy_ex1.txt";

            var output = File.ReadAllText(path);
            var words = output.Split(' ');

            Console.WriteLine(words.Count());
        }
    }
}
