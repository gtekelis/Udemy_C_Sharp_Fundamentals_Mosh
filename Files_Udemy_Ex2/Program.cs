using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Udemy_Ex2
{
    class Program
    {
        /// <summary>
        /// Write a program that reads a text file and displays the longest word in the file.
        /// </summary>

        static void Main(string[] args)
        {
            var path = @"c:\_Temp\udemy_ex1.txt";

            var output = File.ReadAllText(path);
            var words = output.Split(' ');
            var strBuilder = new StringBuilder();
            int tempLength = 0;            

            foreach (var item in words)
            {
                if (item.Length > tempLength)
                {
                    tempLength = item.Length;
                    strBuilder.Clear();
                    strBuilder.Append(item);
                }
            }
                        
            Console.WriteLine(strBuilder);
        }
    }
}
