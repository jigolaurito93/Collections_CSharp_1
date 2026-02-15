using System;

namespace Collections_CSharp_1
{
    public class Employee
    {
        //  Creating properties for the complex object with employee details
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }

        public Employee() { }

        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}