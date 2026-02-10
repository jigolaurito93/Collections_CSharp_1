using System;

namespace Collections_CSharp_1
{
    static public class LambdaAndPredicates
    {
        public static void useLambdaAndPredicates()
        {
            // Regular method to take an input x and return x * x
            int Square(int x)
            {
                return x * x;
            }
            int result = Square(5);
            Console.WriteLine($"The square of 5 is: {result}");

            // Using a lambda expression to achieve the same result
            int SquareLambda(int x) => x * x;
            Console.WriteLine($"The square of 5 using lambda is: {SquareLambda(5)}");

            // using predicate to find all even numbers in a list
            List<int> numbers = [3, 39, 21, 83, 60, 12, 4, 7];

            // A Predicate is a delegate that represents a method that takes a single parameter and returns a boolean value.
            // using Predicate to create a checker for numbers greater than 10. 
            // Returns true if the number is greater than 10, false otherwise.
            Predicate<int> isGreaterThan10 = x => x > 10;

            // Using the FindAll method and predicate to find all numbers greater than 10
            List<int> greaterThan10 = numbers.FindAll(isGreaterThan10);
            Console.WriteLine("Numbers greater than 10:");
            foreach (int number in greaterThan10)
            {
                Console.WriteLine(number);
            }   
        }  
    }
}