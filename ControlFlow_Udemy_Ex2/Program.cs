using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Udemy_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program which takes two numbers from the console and displays the maximum of the two.
            */
            
            Console.WriteLine("Please give a number");
            var number1 = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Please give another number");
            var number2 = Convert.ToInt32( Console.ReadLine() );

            int maxNumber = (number1 > number2) ? number1 : number2;

            Console.WriteLine("The max number is {0}", maxNumber);                        

        }
    }
}
