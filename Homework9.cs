using System;
using System.Collections.Generic;

namespace StudentGradebook
{
    class Student
    {
        // Private, student information
        private int studentID;
        private string studentName;

        // Public, all Student objects
        public static List<Student> studentList = new List<Student>();

        // student's data
        // and adds to the studentList
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        // Public, print the student's information
        public void PrintInfo()
        {
            Console.WriteLine("Student ID: {0}, Student Name: {1}", studentID, studentName);
        }

        // Public, access the student's name
        public string Name
        {
            get { return studentName; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create 4 Student objects with the given information.
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // 2. Create a Dictionary to hold student names and GPAs.
            Dictionary<string, double> gradebook = new Dictionary<string, double>();
            gradebook.Add("Alice", 4.0);
            gradebook.Add("Bob", 3.6);
            gradebook.Add("Cathy", 2.5);
            gradebook.Add("David", 1.8);

            // 3. Check if "Tom" is in the gradebook. If not, add him with a GPA of 3.3.
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
            }

            // 4. Calculate the average GPA.
            double totalGPA = 0;
            foreach (var grade in gradebook.Values)
            {
                totalGPA += grade;
            }
            double avgGPA = totalGPA / gradebook.Count;
            Console.WriteLine("Average GPA: " + avgGPA);

            // 5. Print out GPA is greater than the average.
            Console.WriteLine("Students with GPA greater than average:");
            foreach (Student s in Student.studentList)
            {
                // Check student's name and compare GPA.
                if (gradebook.ContainsKey(s.Name) && gradebook[s.Name] > avgGPA)
                {
                    s.PrintInfo();
                }
            }

            // Wait for user input before closing 
            Console.ReadLine();
        }
    }
}