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
            Console.WriteLine("6. Quit Menu");

            Console.Write("\nSelect your option: ");
            string? choice = Console.ReadLine();
            if (string.IsNullOrEmpty(choice)) continue;

            tasks = Storage.Load(filePath);

            switch (choice)
            {
                case "1":
                    id++;
                    Console.Write("Enter name of task: ");
                    string? c1Name = Console.ReadLine();
                    Console.WriteLine();

                    if (string.IsNullOrEmpty(c1Name)) break;
                    tasks.Add(new Task(id,c1Name));

                    Storage.Save(filePath, tasks);
                    Console.WriteLine("Task added succesfully.");

                    break;
                case "2":
                    Console.Write("Enter ID of task to delete: ");
                    if (!int.TryParse(Console.ReadLine(), out var c2Id))
                    {
                        Console.WriteLine("Invalid integer.");
                        break;
                    }
                    Console.WriteLine();
                    tasks.RemoveAll(t => t.Id == c2Id);
                    Storage.Save(filePath, tasks);
                    Console.WriteLine("Task deleted succesfully.");

                    break;
                case "3":
                    Console.Write("Enter ID of task to toggle completion for: ");
                    if (!int.TryParse(Console.ReadLine(), out var c3Id))
                    {
                        Console.WriteLine("Invalid integer.");
                        break;
                    }
                    Console.WriteLine();
                    var found = tasks.Find(t => t.Id == c3Id);
                    if (found == null)
                    {
                        Console.WriteLine("Item not found.");
                        break;
                    }
                    found.Completed = !found.Completed;
                    Storage.Save(filePath, tasks);
                    Console.WriteLine(found.Completed ? "Task: Completed" : "Task: Not done");

                    break;
                case "4":
                    Console.WriteLine("--- Tasks ---");
                    foreach (Task item in tasks)
                    {
                        Console.WriteLine($"ID: {item.Id} | task: {item.Name} | completed: {item.Completed}");
                    }
                    break;
                case "5":
                    tasks.Clear();
                    Console.WriteLine("All items deleted succesfully.");
                    Storage.Save(filePath, tasks);
                    break;
                case "6":
                    return;
            }


            Console.WriteLine("\n Type any key to return to Menu...");
            Console.ReadKey();
        }
    }
}
