using System;   

namespace Collections_CSharp_1
{
    public class Sorting
    {
        public static void useSorting()
        {
            // Method for printing the list of numbers
            void PrintingList(List<int> numbers)
            {
                foreach(int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }

            // Creating a list of numbers
            List<int> numbers = new List<int>{
                5,
                2,
                9,
                1,
                3
            };

            Console.WriteLine("Numbers before sorting:");
            PrintingList(numbers);

            // Sorting the list of numbers
            numbers.Sort();
            // Dislaying the sorted list of numbers
            Console.WriteLine("\nNumbers after sorting:");
            PrintingList(numbers);
      
        }
    }
} 