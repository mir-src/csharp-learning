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
            if (grade <= 100 && grade > 0) {
                Grades[name] = grade;
                Console.WriteLine("Grade added succesfully.");
            }
            else
            {
                Console.WriteLine("Invalid grade, bigger than 100 or smaller than 1");
            }
        }
    }
    public static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------");
            Console.WriteLine("---MENU---");
            Console.WriteLine("1. Add Student to manager");
            Console.WriteLine("2. Show Student List");
            Console.WriteLine("3. Remove Student from manager");
            Console.WriteLine("4. Add Grade to student");
            Console.WriteLine("5. Change Grade of student");
            Console.WriteLine("6. Remove Domain (e.g. English, Computer Science)");
            Console.WriteLine("7. Quit");
            Console.WriteLine("---------------");


            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input)) { continue; }
            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter the name of the student:");
                    string name = Console.ReadLine();
                    studentList.Add(new Student(name));
                    break;
                case "2":
                    foreach (Student student in studentList)
                    {
                        Console.WriteLine($"\nStudent: {student.Name}");
                        foreach (var Grade in student.Grades)
                        {
                            Console.WriteLine($"{Grade.Key} -> {Grade.Value}");
                        }
                        Console.WriteLine("----------------");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter the name of the student to remove:");
                    string studentName = Console.ReadLine();
                    var removed = studentList.RemoveAll(student => student.Name == studentName);
                    if (removed > 0)
                    {
                        Console.WriteLine($"The student {studentName} has been removed succesfully.");
                    }
                    else
                    {
                        Console.WriteLine($"The student '{studentName}' doesn't exist.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter the name of the student you want to add a grade to:");
                    string studentNameGrade = Console.ReadLine();

                    Student foundStudent = studentList.Find(s => s.Name.Equals(studentNameGrade, StringComparison.OrdinalIgnoreCase));
                    if (foundStudent == null)
                    {
                        Console.WriteLine("Student Not Found.");
                        break;
                    }
                    Console.WriteLine("Enter subject:");
                    string subject = Console.ReadLine();

                    Console.WriteLine("Enter grade:");
                    if (!int.TryParse(Console.ReadLine(), out int grade)){
                        Console.WriteLine("Invalid grade.");
                        break;
                    }

                    foundStudent.AddGrade(subject, grade);

                    break;
                case "5":
                    Console.WriteLine("Change grade of Student.");
                    string studentNameChange = Console.ReadLine();

                    Student changeStudent = studentList.Find(s => s.Name.Equals(studentNameChange, StringComparison.OrdinalIgnoreCase));
                    if (changeStudent == null)
                    {
                        Console.WriteLine("Student Not Found.");
                        break;
                    }
                    Console.WriteLine("Enter subject:");
                    string Subject = Console.ReadLine();

                    if (!changeStudent.Grades.ContainsKey(Subject)) {
                        Console.WriteLine("Subject Not Found.");
                        break;
                    }


                    Console.WriteLine("Enter a grade (int):");
                    if (!int.TryParse(Console.ReadLine(), out int grd))
                    {
                        Console.WriteLine("Invalid grade or Student doesn't exist.");
                        break;
                    }

                    changeStudent.Grades[Subject] = grd;

                    Console.WriteLine("Grade changed succesfully.");

                    break;
                case "6":
                    break;
                case "7":
                    return;
            }
            Console.WriteLine("\n Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}