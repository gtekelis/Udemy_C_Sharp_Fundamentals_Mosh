using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Udemy_Ex4
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space. 
        /// Use the words to create a variable name with PascalCase. 
        /// For example, if the user types: "number of students", display "NumberOfStudents". 
        /// Make sure that the program is not dependent on the input. 
        /// So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
        /// </summary>

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words separated by spaces...");
            var input = Console.ReadLine();

            var arr = input.Split(' ');
            var strinBldr = new StringBuilder();
            string temp;
            
            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i].ToLower();
                for (int j = 0; j < arr[i].Length; j++)
                {                    
                    if (j==0)
                    {
                        strinBldr.Append(temp[j].ToString().ToUpper());
                        continue;
                    }
                    strinBldr.Append(temp[j]);                   
                }                               
            }
            Console.WriteLine(strinBldr);
        }
    }
}
