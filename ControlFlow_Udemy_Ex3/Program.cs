using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Udemy_Ex3
{
    class Program
    {
        /*
        Write a program and ask the user to enter the width and height of an image.
        Then tell if the image is landscape or portrait.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Give image width...");
            var imgWidth = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Give image height...");
            var imgHeight = Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine( (imgWidth > imgHeight)? ImageOrientation.Landscape : ImageOrientation.Portrait );

        }

        public enum ImageOrientation {
            Landscape,
            Portrait
        }
    }
}
