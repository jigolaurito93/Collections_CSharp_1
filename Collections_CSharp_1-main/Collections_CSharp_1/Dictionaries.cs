using System;
using System.Collections.Generic;

namespace Collections_CSharp_1
{
    public class Dictionaries
    {
        public static void UsingDictionaries()
        {   
            // Creating a Dictionary without a predefined key value pairs
            Dictionary<int,string> employees = new Dictionary<int, string>();

            // Use Add method to add key value pairs
            employees.Add(321, "Marvin");
            employees.Add(322, "Kenan");
            
            // Access the values by indexing the dictionary
            Console.WriteLine(employees[321]);
            Console.WriteLine(employees[322]);
        }
    }
}