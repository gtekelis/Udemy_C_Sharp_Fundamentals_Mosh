using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fundamentals_1_Mosh
{
    class Program
    {

        public enum ShippingType
        {
            Delivery = 1,
            Takeaway = 2,
        }

        static void Main(string[] args)
        {
            string Name = string.Empty;
            int i = 0;
            do
            {
                Console.WriteLine("Please enter your name: ");
                Name = Console.ReadLine();
                Console.WriteLine(i++);
            } while (Name.Length <= 0);

            Console.WriteLine(string.Format("Shipping method: {0}", ShippingType.Delivery));

            Console.WriteLine("Your name is {0}", Name);
            
            Console.ReadLine();            

        }
    }
}
