using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Udemy_Ex3
{
    class Program
    {
        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
        /// A valid time should be between 00:00 and 23:59.
        /// If the time is valid, display "Ok"; otherwise, display "Invalid Time".
        /// If the user doesn't provide any values, consider it as invalid time.
        /// </summary>

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter time...");
                    var input = Console.ReadLine();
                    var parsedTime = DateTime.Parse(input);

                    var minTime = DateTime.Parse("00:00");
                    var maxTime = DateTime.Parse("23:59");


                    if (parsedTime >= minTime && parsedTime <= maxTime)
                    {
                        Console.WriteLine("time is ok");
                        break;
                    }
                    Console.WriteLine("invalid time");
                    continue;
                }
                catch (Exception)
                {
                    Console.WriteLine("invalid time");
                    continue;
                }
            }
        }
    }
}
