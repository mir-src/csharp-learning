using System;

namespace FileBasedToDoList;

class Program
{
    public static void Main(string[] args)
    {
        string filePath = "tasks.json";
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Add task to list");
            Console.WriteLine("2. Remove task from list");
            Console.WriteLine("3. Toggle Task Completion");
            Console.WriteLine("4. Display Tasks");
            Console.WriteLine("5. Delete All tasks");
            Console.WriteLine("6. Mark All Tasks as Complete/Incomplete");
            Console.WriteLine("7. Quit Menu");

            Console.WriteLine("\n Type any key to return to Menu...");
            Console.ReadKey();
        }
    }
}
