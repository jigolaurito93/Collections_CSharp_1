using System;

namespace Collections_CSharp_1
{
    public class DictionariesWithObj
    {
        public static void UsingDictionariesWithObj()
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
            
            employees.Add(101, new Employee("Peter Jackson", 42, 80000));
            employees.Add(102, new Employee("John Doe", 52, 120000));
            employees.Add(103, new Employee("Sarah Sherman", 65, 20000));

            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name} earns {item.Value.Salary} and is {item.Value.Age} years old.");
            }
        }
    }
}