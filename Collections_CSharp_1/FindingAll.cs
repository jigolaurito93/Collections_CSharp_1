using System;

namespace Collections_CSharp_1
{
    static public class FindingAll
    {
        public static void usingFindAll()
        {
            // Creating a list of numbers
            List<int> myNumbers = [
                5, 3, 10, 52, 9, 1, 82, 61
            ];

            // Creating a method to print the list of numbers
            void PrintNumbers(List<int> numbers)
            {
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            // Print the original list of numbers
            Console.WriteLine("Original list of numbers:");
            PrintNumbers(myNumbers);

            // Using the FindAll method to find all numbers greater than 10
            List<int> numbersGreaterThan10 = myNumbers.FindAll(x => x > 10);

            // Print the numbers greater than 10
            Console.WriteLine("\nNumbers greater than 10:");
            PrintNumbers(numbersGreaterThan10);
        }
    }
}