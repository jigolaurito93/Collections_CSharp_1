using System;

namespace Collections_CSharp_1
{
    public static class Nullables
    {
        public static void UsingNullables()
        {
            // Nullables are a special type that can represent all the values of an underlying value type, 
            // plus an additional null value. 
            // They are useful for representing situations where a value may be absent or not applicable.

            int? age = null; // This is a nullable integer, it can hold an integer value or null.
            int myAge = 32; // This is a regular integer, it cannot be null.
            //int hisAge = age ?? 0; // Using the null-coalescing operator to provide a default value if age is null.
            if (age.HasValue)
            {
                Console.WriteLine($"The age is: {age.Value}"); // 
                Console.WriteLine($"The new age is: {age.Value + myAge}"); // It will return null if age is null, otherwise it will return the sum of age and myAge.
            }
            else
            {
                Console.WriteLine("The value is null.");
            }
        }
    }
}