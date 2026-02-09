using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_CSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>(); // This is like saying "Here's a box for holding numbers."
            numbers.Add(1); // Add the number 1 to the box.
            numbers.Add(2); // Add the number 2 to the box.
            */

            // Creating a list of colors but only taking strings
            List<string> colors = new List<string>();
            // Method for Lists that adds a value
            colors.Add("Black");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Blue");
            colors.Add("Brown");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

        }
    }
}
