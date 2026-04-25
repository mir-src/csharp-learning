using System;
using System.Collections.Generic;
using System.Text;

namespace FileBasedToDoList
{
    internal class Task
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool Completed { get; set; } 
        public Task(int id, string name)
        {
            Id = id;
            Name = name;
            Completed = false;
        }
    }
}
