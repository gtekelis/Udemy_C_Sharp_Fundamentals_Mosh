using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbersClass_Udemy_Lecture47
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();

            for (var i = 0; i < 10; i++)
            {
                Console.Write((char)random.Next(97, 122));                
            }
            Console.WriteLine();
        }
    }
}
