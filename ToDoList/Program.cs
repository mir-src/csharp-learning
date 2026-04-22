using System;

namespace ToDoList;

class Program
{
    class Helpers
    {
        public static int? ReadInt()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var output)) { return output; }
                else { return null; }
            }
        }
    }
    class Item
    {
        public int Number { get; set; } 
        public string Name { get; set; }
        public bool Value { get; set; }
    }
    public static void Main(string[] args)
    {
        List<Item> list = new List<Item>();
        
        int tag = 1;

        while (true)
        {
            Console.WriteLine("---Menu---");
            Console.WriteLine("1. Create Task");
            Console.WriteLine("2. Show Tasks");
            Console.WriteLine("3. Delete Tasks");
            Console.WriteLine("4. Check Tasks");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(choice)) { continue; }


            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Task name:");
                    string name = Console.ReadLine();
                    list.Add(new Item { Number = tag, Name = name, Value = false});
                    tag++; 
                    Console.WriteLine("Task created succesfully");
                    break;
                case "2":
                    foreach (Item task in list)
                    {
                        Console.WriteLine($"ID: {task.Number} | Task: {task.Name}");
                    }
                    break;
                case "3":
                    Console.WriteLine("Enter number of the task to delete:");
                    var input = Helpers.ReadInt();
                    int removed = list.RemoveAll(task => task.Number == input);

                    if (removed == 0)
                    {
                        Console.WriteLine("No task found with that ID.");
                    }
                    else
                    {
                        Console.WriteLine("Task deleted succesfully.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Enter number of task to mark:");
                    var selectedNumber = Helpers.ReadInt();
                    if (selectedNumber != null)
                    {
                        var task = list.FirstOrDefault(t => t.Number == selectedNumber);

                        if (task != null)
                        {
                            task.Value = !task.Value;
                            Console.WriteLine($"Task '{task.Name}' is now: {(task.Value ? "Done" : "Not Done")}");
                        }
                        else
                        {
                            Console.WriteLine("Task not found.");
                        }
                    }
                    break;
                case "5":
                    return;
            }
        }

    }  
}
