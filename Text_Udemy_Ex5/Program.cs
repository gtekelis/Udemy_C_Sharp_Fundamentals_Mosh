using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Udemy_Ex5
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter an English word. 
        /// Count the number of vowels (a, e, o, u, i) in the word. 
        /// So, if the user enters "inadequate", the program should display 6 on the console.
        /// </summary>
        
        static void Main(string[] args)
        {
            var listOfVowels = new List<char>();

            Console.WriteLine("Enter a word...");
            var input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'a':
                        listOfVowels.Add('a');
                        break;
                    case 'e':
                        listOfVowels.Add('e');
                        break;
                    case 'o':
                        listOfVowels.Add('o');
                        break;
                    case 'u':
                        listOfVowels.Add('u');
                        break;
                    case 'i':
                        listOfVowels.Add('i');
                        break;
                    default:
                        break;
                }
            }
            var numOfVowels = listOfVowels.Count();
            Console.WriteLine("number of vowels in word: {0}", numOfVowels);                                    
        }
    }
}
