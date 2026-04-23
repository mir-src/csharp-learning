using System;
using System.Collections.Generic;

namespace StudentManager; 

class Program
{
    class Student
    {
        public string Name { get; set; }
        public Dictionary<string, int> Grades { get; set; }
        public Student(string name)
        {
            Name = name;

            Grades = new Dictionary<string, int>();
        }

        public void AddGrade(string name, int grade)
        {
            Grades[name] = grade; 
        }
    }
    public static void Main(string[] args)
    {
        Student s = new Student("Alex");
        s.Grades["Math"] = 95;
        s.Grades["English"] = 88;

        Student c = new Student("Cornelia");

        c.AddGrade("Indonesian", 100);
        c.AddGrade("Sport", 100);

        foreach (var pair in c.Grades)
        {
            Console.WriteLine($"{pair.Key} -> {pair.Value}");
        }
    }
}