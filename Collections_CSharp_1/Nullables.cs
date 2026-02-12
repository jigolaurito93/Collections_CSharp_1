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

            int? nullableInt = null; // This is a nullable integer, it can hold an integer value or null.
            if (nullableInt.HasValue)
            {
                Console.WriteLine($"The value is: {nullableInt.Value}");
            }
            else
            {
                Console.WriteLine("The value is null.");
            }
        }
    }
}