using System;

namespace Collections_CSharp_1
{
    public class ComplexObjInList
    {
        public static void UsingComplexObjInList()
        {
            // Creating a list of complex objects (Employees)
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 30 },
                new Employee { Name = "Bob", Age = 25 },
                new Employee { Name = "Charlie", Age = 35 }
            };

            // Using Add method to add a new Employee object to the list
            employees.Add(new Employee { Name = "Jose", Age = 32 });

            // Displaying the list of employees
            Console.WriteLine("List of Employees:");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            }
            
        }
    }
}