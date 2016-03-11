using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            //dates
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.Year);
            Console.WriteLine(now.ToString("yyyy-MM-dd"));

            //timespan
            var start = DateTime.Now;
            var end = start.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("timespan is {0}", duration);

            //properties
            Console.WriteLine(duration.Hours);

            //parse
            Console.WriteLine(TimeSpan.Parse("03:02:01"));
            var parsedTimespan = TimeSpan.Parse("03:02:01");


            var name = "George";
            name.ToUpper();
            Console.WriteLine(name.ToUpper());
                        
        }
    }
}
