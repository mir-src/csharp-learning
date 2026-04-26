using System;

namespace FileBasedToDoList;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "tasks.json";
        List<Task> tasks = new List<Task>();
        int id = 0;
        Storage.Save(filePath, tasks);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add Task to list");
            Console.WriteLine("2. Remove Task from list");
            Console.WriteLine("3. Toggle Task Completion");
            Console.WriteLine("4. Display Tasks");
            Console.WriteLine("5. Delete All Tasks");
            Console.WriteLine("6. Mark All Tasks as Complete/Incomplete");
            Console.WriteLine("7. Quit Menu");

            Console.Write("\nSelect your option: ");
            string? choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice)) continue;

            tasks = Storage.Load(filePath);

            switch (choice)
            {
                case "1":
                    id++;
                    string? c1Name = Console.ReadLine();

                    if (string.IsNullOrEmpty(c1Name)) break;
                    tasks.Add(new Task(id,c1Name));

                    Storage.Save(filePath, tasks);

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    Console.WriteLine("--- Tasks ---");
                    foreach (Task item in tasks)
                    {
                        Console.WriteLine($"ID: {item.Id} | task: {item.Name} | completed: {item.Completed}");
                    }
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    return;
            }


            Console.WriteLine("\n Type any key to return to Menu...");
            Console.ReadKey();
        }
    }
}
