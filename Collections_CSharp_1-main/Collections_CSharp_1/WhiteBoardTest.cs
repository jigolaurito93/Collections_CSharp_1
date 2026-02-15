/*
Create a C# program that declares a dictionary where the key is a string and the value is a custom object. The program should:

Define a class Student with properties Id, Name, and Grade.

To be robust across graders that treat warnings as errors, initialize Name to string.Empty (i.e., public string Name { get; set; } = string.Empty;).

Initialize a dictionary with keys as student names and values as Student objects.

Add at least three Student objects to the dictionary.

Iterate through the dictionary and print each student’s details from the object (use student.Name, not the dictionary key).

Print exactly the following three lines, in this order:

Name: John, Id: 1, Grade: 85
Name: Alice, Id: 2, Grade: 90
Name: Bob, Id: 3, Grade: 78
*/


using System;

namespace Collections_CSharp_1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Grade { get; set; }

        public Student(int id, string name, int grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }
    }

    public class WhiteBoardTest
    {
        public static void PrintStudents()
        {
            var students = new Dictionary<string, Student>
            {
                ["John"] = new Student(1, "John", 85),
                ["Alice"] = new Student(2, "Alice", 90),
                ["Bob"] = new Student(3, "Bob", 78)
            };

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            };
        }
    }
}