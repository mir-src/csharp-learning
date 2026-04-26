using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;


namespace FileBasedToDoList
{
    internal class Storage
    {
        public static List<Task> Load(string filepath)
        {
            if (!File.Exists(filepath))
            {
                return new List<Task>();
            }
            string json = File.ReadAllText(filepath);
            return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
        }
        public static void Save(string filepath, List<Task> list)
        {
            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(filepath, json);
            Console.WriteLine("Saved To File");
        }
    }
}
