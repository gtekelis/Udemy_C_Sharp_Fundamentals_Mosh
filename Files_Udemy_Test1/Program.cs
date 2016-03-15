using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Udemy_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Files Test 1");
            File.Copy(@"c:\_Temp\codeproject_vader.gif", @"c:\Users\gtekelis\Desktop\codeproject_vader.gif", true);
        }
    }
}
