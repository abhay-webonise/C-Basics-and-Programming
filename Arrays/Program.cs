using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "<name>", "Abhay" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}