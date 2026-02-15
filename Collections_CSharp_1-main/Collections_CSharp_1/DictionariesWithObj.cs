using System;

namespace Collections_CSharp_1
{
    public class DictionariesWithObj
    {
        public static void UsingDictionariesWithObj()
        {
            /*
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            
            employees.Add(101, new Employee("Peter Jackson", 42, 80000));
            employees.Add(102, new Employee("John Doe", 52, 120000));
            employees.Add(103, new Employee("Sarah Sherman", 65, 20000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name} earns {item.Value.Salary} and is {item.Value.Age} years old.");
            }
            */

            // Using strings as Key
            // When using strings as key, you have to put square brackets around it.
            var localStates = new Dictionary<string, string>
            {
                ["NY"] = "New York",
                ["CA"] = "California",
                ["IL"] = "Illinois"
            };

            // Using TryGetValue to check if a Value is in a dictionary by using its Key as an argument, 
            // then use the keyword "out", then declare the data type, then the variable name. It returns a boolean
            if (localStates.TryGetValue("IN", out string state))
            {
                Console.WriteLine(state);
            }
            else
            {
                Console.WriteLine("Not in dictionary");
            };

            // Using foreach loop to iterate every item in the dictionary
            foreach (var (code, statue) in localStates)
            {
                Console.WriteLine($"The state code is {code} for the state of {statue}.");
            };

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(20);
            list.AddLast(10);
            list.AddFirst(5);

            foreach (var item in list)
            Console.WriteLine(item);
        }
    }
}