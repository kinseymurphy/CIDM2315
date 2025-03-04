using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
          //Q1 implementation and Q2 printing
        {
            // Creating Professors
            Professor prof1 = new Professor("Alice", "Java", 9000);
            Professor prof2 = new Professor("Bob", "Math", 8000);

            // Creating Students
            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            // Printing Professor details
            Console.WriteLine("Professor Details:");
            prof1.PrintDetails();
            prof2.PrintDetails();

            // Printing Student details
            Console.WriteLine("\nStudent Details:");
            student1.PrintDetails();
            student2.PrintDetails();

            // Calculating and printing differences
            double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
            Console.WriteLine($"\nSalary Difference: {salaryDifference}");

            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"Total Grade of Lisa and Tom: {totalGrade}");
        }
    }

    class Professor
    {
        private string profName;
        private string classTeach;
        private double salary;

        public Professor(string name, string classTeaching, double salaryAmount)
        {
            profName = name;
            classTeach = classTeaching;
            salary = salaryAmount;
        }

        public void SetSalary(double salaryAmount)
        {
            salary = salaryAmount;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {profName}, Class: {classTeach}, Salary: {salary}");
        }
    }

    class Student
    {
        private string studentName;
        private string classEnroll;
        private double studentGrade;

        public Student(string name, string enrolledClass, double grade)
        {
            studentName = name;
            classEnroll = enrolledClass;
            studentGrade = grade;
        }

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {studentName}, Class: {classEnroll}, Grade: {studentGrade}");
        }
    }
}
