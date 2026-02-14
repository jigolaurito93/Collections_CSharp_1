using System;
using System.Collections.Generic;

namespace Collections_CSharp_1
{
    public class Dictionaries
    {
        public static void UsingDictionaries()
        {   
            // Dictionaries are a collection of key value pairs.
            // They are unordered and cannot contain duplicate keys.
            // Creating a Dictionary without a predefined key value pairs
            Dictionary<int,string> employees = new Dictionary<int, string>();

            // creating a dictionary with a predefined key value pairs
            Dictionary<int,string> customers = new Dictionary<int, string>
            {
                {001, "James Andrew"},
                {002, "Brandon Smith"},
                {003, "Alyssa Peterson"},
                {004, "Jessica Thompson"},
            };

            // Use Add method to add key value pairs
            employees.Add(001, "Marvin Pock");
            employees.Add(002, "Kenan Froal");
            employees.Add(003, "John Doe");
            employees.Add(004, "Jane Doe");
            employees.Add(005, "Jim Doe");
            
            // Access the values by indexing the dictionary
            Console.WriteLine("Employee 001: " + employees[001]);
            Console.WriteLine("Employee 002: " + employees[002]);

            // Change the value of employee 001 from Marvin to James
            employees[001] = "James Tundt";
            Console.WriteLine("After changing the value of employee 001:");
            Console.WriteLine("Employee 001: " + employees[001]);

            // Remove an employee from the dictionary using the Remove method with the key
            employees.Remove(002);
            Console.WriteLine("After removing employee 002:");
            Console.WriteLine("Employee 001: " + employees[001]);
            // Cannot access the removed employee, it will throw an error.
            //Console.WriteLine("Employee 002: " + employees[002]);

            // Using foreach to iterate through the dictionary
            // Note: Employee 002 was removed, so it will not be included in the output.
            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine("Employee ID: " + employee.Key + " - Name: " + employee.Value);
            }

            // Check if a key exists in the dictionary using the ContainsKey method
            if (employees.ContainsKey(003))
            {
                Console.WriteLine("Employee 003 exists in the dictionary.");
            }
            else
            {
                Console.WriteLine("Employee 003 does not exist in the dictionary.");
            }

            // Check if a value exists in the dictionary using the ContainsValue method
            if (employees.ContainsValue("Jane Doe"))
            {
                Console.WriteLine("Employee 004 exists in the dictionary.");
            }
            else    
            {
                Console.WriteLine("Employee 004 does not exist in the dictionary.");
            }

            // Get the number of key value pairs in the dictionary using the Count property
            Console.WriteLine("Number of employees in the dictionary: " + employees.Count);

            // TryAdd method to add a key value pair to the dictionary and check if it was added successfully
            // Returns a boolean value, returns true if the key value pair was added successfully, returns false if the key already exists in the dictionary
            bool isAdded = employees.TryAdd(004, "Carter Wildenradt");
            if (isAdded)
            {
                Console.WriteLine("Employee 004 was added to the dictionary.");
            }
            else
            {
                Console.WriteLine("Employee 004 already exists in the dictionary.");
            }
        }
    }
}