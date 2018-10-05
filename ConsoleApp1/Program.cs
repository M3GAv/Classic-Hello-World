using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            credits();
            Console.WriteLine("Hello World!");

        }

        static void credits()
        {
            string appName = "Hello World";
            string appVersion = "1.0";
            string appAuthor = "Mateusz Celka";
            Console.WriteLine("{0} version: {1} by {2}",appName,appVersion,appAuthor);
        }
    }
}
