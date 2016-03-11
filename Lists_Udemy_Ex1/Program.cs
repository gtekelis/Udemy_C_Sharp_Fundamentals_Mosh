using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Udemy_Ex1
{
    class Program
    {
        /// <summary>
        /// When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
        /// If no one likes your post, it doesn't display anything.
        /// If only one person likes your post, it displays: [Friend's Name] likes your post.
        /// If two people like your post, it displays: [Friend 1]
        /// and[Friend 2] like your post.
        /// If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
        /// Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>

        static void Main(string[] args)
        {
            var input = string.Empty;
            var namesList = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a name or press enter to exit.");
                input = Console.ReadLine();

                if (input != "")
                {
                    namesList.Add(input);
                }
                else
                {
                    break;
                }
            }
            
            switch (namesList.Count)
            {
                case 0:
                    Console.WriteLine();
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", namesList[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", namesList[0], namesList[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post", namesList[0], namesList[1], namesList.Count - 2);
                    break;
            }
        }
    }
}
