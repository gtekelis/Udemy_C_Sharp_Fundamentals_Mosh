using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Udemy_Ex2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or ok to exit...");
                var input = Console.ReadLine();


                if (input == "ok")
                {
                    break;
                }
                else {
                    sum += Convert.ToInt32(input);                    
                }

            }

            Console.WriteLine(sum);
        }
    }
}
