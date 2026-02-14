using System;

namespace Collections_CSharp_1
{
    class AnyMethod
    {
        public static void usingAnyMethod()
        {
            // "Any" method is used to determine if any elements in a collection satisfy a specified condition. 
            // It returns true if "at least one element" meets the condition, and false otherwise.

            List<int> numbers = [3, 39, 21, 83, 60, 12, 4, 7];
            // Using the "Any" method to check if there are any even numbers in the list
            // It will return a boolean value indicating whether any even numbers are present in the list.
            bool evenNumbers = numbers.Any(x => x% 2 == 0);
            Console.WriteLine($"Are there any even numbers in the list? {evenNumbers}");

            // Creating a list that will return false when we use the "Any" method to check for even numbers
            // Creating a predicate that checks it.
            // The problem: Any() expects a Func<T, bool>, not a Predicate<T>. 
            // They're similar but not interchangeable.
            List<int> oddNumbers = [3, 39, 21, 83, 7];
            // Predicate<int> isEven = x => x % 2 == 0;
            Func<int, bool> isEven = x => x % 2 == 0;
            bool evenNumbersInOddList = oddNumbers.Any(isEven);
            Console.WriteLine($"Are there any even numbers in the odd list? {evenNumbersInOddList}");
        }
    }
}