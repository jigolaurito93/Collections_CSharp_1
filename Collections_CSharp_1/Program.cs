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
            colors.Add("Black");

            static void PrintColors(List<string> colors)
            {
                Console.WriteLine("These are the colors in the list:");

                foreach (string color in colors)
                {
                    Console.WriteLine("- " + color);
                }
            }

            PrintColors(colors);

            // method to remove a value from the list
            colors.Remove("Black"); // This will remove the first occurrence of "Black" from the list.

            PrintColors(colors);

            // Remove method also returns boolean value to indicate if the item was successfully removed or not
            bool isColorRemoved = colors.Remove("Yellow");
            Console.WriteLine($"Was 'Yellow' removed? {isColorRemoved}");

            PrintColors(colors);

            colors.Add("Black");
            colors.Add("Yellow");
            colors.Add("Green");
            colors.Add("Black");

            // Remove all occurrences of "Black" from the list
            colors.RemoveAll(color => color == "Black");

            PrintColors(colors);
        } 
    }
}
