using System;
using System.Collections.Generic;
using System.Text;

namespace MVPHabitTracker.Models
{
    internal class Habit
    {
        public string Name { get; private set; }
        public DateOnly CreatedAt { get; private set; } 
    }
}
